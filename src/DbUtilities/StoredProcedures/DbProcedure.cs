using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using DbUtilities.DataTransformation;

namespace DbUtilities.StoredProcedures
{
    public interface IResultTypeTextBuilder
    {
        string BuildResultTypeText(object parameters);
    }
    public abstract class DbProcedure<T> : IResultTypeTextBuilder
    {
        private readonly Func<DbConnection> _connectionFactory;
        private readonly Action<object> _logger;

        protected DbProcedure(Func<DbConnection> connectionFactory, Action<object> logger = null)
        {
            _connectionFactory = connectionFactory;
            _logger = logger;
        }

        public  void Execute(object parms)
        {
            Execute(GetProcName(), parms);
        }
        protected void Execute(string procName, object parms)
        {
            DbConnection connection = _connectionFactory();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (DbCommand cmd = connection.CreateCommand())
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procName;

                PopulateParameters(parms, cmd);

                cmd.ExecuteNonQuery();
            }

        }

        public  IEnumerable<T> FetchData(object parms)
        {
            return FetchData(GetProcName(),parms);
        }
        protected IEnumerable<T> FetchData(string procName, object parms)
        {
            using (DbConnection connection = _connectionFactory())
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procName;

                    PopulateParameters(parms, cmd);
                    //var table = GetTable(cmd);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return GetData(dataReader);
                    }
                }
            }
        }

        protected abstract string GetProcName();

        public string BuildResultTypeText(object parms)
        {
            var fieldNames = new List<string>();
            var sb = new StringBuilder();
            sb.AppendLine("public class ReturnTypeName {");
            
            using (DbConnection connection = _connectionFactory())
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = GetProcName();

                    PopulateParameters(parms, cmd);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var table = new DataTable(); 
                        table.Load(dataReader);
                        for (var i = 0; i < table.Columns.Count; i++)
                        {
                            sb.Append('\t');
                            sb.Append($"public {table.Columns[i].DataType.Name}{AppendNullableOperator(table.Columns[i])} {table.Columns[i].ColumnName} ");
                            sb.Append("{ get; set; }");
                            sb.AppendLine("");
                        }
                    }
                }
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        private string AppendNullableOperator(DataColumn col)
        {
            return col.AllowDBNull ? "?" : "";
        }

        protected  IEnumerable<T> GetData(DbDataReader dataReader)
        {
            var data = new List<T>();
            if (!dataReader.HasRows) return new List<T>();
                if (dataReader.IsClosed) throw new Exception("dataReader was closed!");
                var fieldReader = new DbFieldReader(dataReader, _logger);
                while (dataReader.Read())
                {
                    data.Add(GetLine(dataReader, fieldReader));
                }

                return data;
        }

        protected T GetLine(DbDataReader reader, DbFieldReader fieldReader)
        {
            if (typeof(T).FullName == null) return default(T);
            var obj = (T)typeof(T).Assembly.CreateInstance(typeof(T).FullName);
            if (obj == null)
                throw new Exception($"Could not create object of type {typeof(T).FullName}");
            foreach (var prop in typeof(T).GetProperties())
            {
                prop.SetValue(obj, GetValue(fieldReader, fieldReader.GetOrdinalByName(prop.Name),prop));
            }

            return obj;
        }

        protected object GetValue(DbFieldReader fieldReader, int ordinal, PropertyInfo prop)
        {
            Log(ordinal);
            return fieldReader.Read(ordinal, prop.PropertyType);
        }

        private void Log(object val)
        {
            if (_logger == null) return;
            _logger(val);
        }

        protected void PopulateParameters(object parms, DbCommand cmd)
        {
            var props = parms.GetType().GetProperties();
            foreach(var prop in props)
            {
                var parm = new SqlParameter($"@{prop.Name}", prop.GetValue(parms));
                cmd.Parameters.Add(parm);
            }
        }

        protected virtual DataTable GetTable(DbCommand command)
        {
            var reader = command.ExecuteReader();
                // use data table to buffer results
                var ds = new DataSet();
                ds.EnforceConstraints = false;
                var table = new DataTable();
                ds.Tables.Add(table);
                ds.EnforceConstraints = false;
                table.Load(reader);
                return table;
        }

    }
}
