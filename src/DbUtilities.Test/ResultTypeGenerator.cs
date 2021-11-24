using System;
using System.Configuration;
using System.Data.SqlClient;
using DbUtilities.StoredProcedures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbUtilities.Test
{
    [TestClass]
    public class ResultTypeGenerator
    {
        private string _spName = "spPanel_GetDeviceConfiguration";
        private string _connectionString;
        private IResultTypeTextBuilder _sp;

        [TestMethod]
        public void GenerateResultType()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["siteConnectionDev"].ConnectionString;
            _sp = GetStoredProc();
            var text = _sp.BuildResultTypeText(new DeviceConfigurationParameters() { locationId = Guid.Parse("AA125FFE-AC9F-4F99-9F62-00172B1022E1") });
            Console.WriteLine(text);
        }

        private IResultTypeTextBuilder GetStoredProc() 
        {
            return new spPanel_GetDeviceConfiguration(() => new SqlConnection(_connectionString), null);
        }
    }


}
