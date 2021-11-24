using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DbUtilities.Utilities
{
    public static class ObjectExtensions
    {
        public static object ConvertFlatObject(this object flatObject, Type returnType)  
        {
            var obj = returnType.CreateInstance();
            var flatProps = returnType.GetProperties();
            foreach (var prop in flatProps)
            {
                obj.ApplyRecursiveAssignments(flatObject, prop);
            }
            
            return obj;
        }

        public static void ApplyRecursiveAssignments(this object obj, object flattenedObject, PropertyInfo prop)
        {
            var objType = obj.GetType();
            var props = objType.GetProperties();
            Console.WriteLine(props.AssignClassChildren(obj, flattenedObject));

        }

        public static string AssignClassChildren(this PropertyInfo[] props, object obj, object flattenedObject)
        {
            var assignmentFailures = new StringBuilder();
            var flattenedProps = flattenedObject.GetType().GetProperties(); 
            foreach (var toProp in props)
            {
                var matchingProp = flattenedProps.FirstOrDefault(p => p.Name == toProp.Name);
                if (matchingProp == null)
                    continue;
                if (toProp.PropertyType.IsClass && !toProp.PropertyType.IsAssignableFrom(typeof(string)))
                {
                    var child = toProp.PropertyType.CreateInstance();
                    toProp.SetValue(obj, child);
                    assignmentFailures.AppendLine(child.GetType().GetProperties().AssignClassChildren(child, flattenedObject));
                }
                else
                {
                    try
                    {
                        toProp.SetValue(obj, matchingProp.GetTypedValue(toProp, flattenedObject, obj));

                    }
                    catch (Exception ex)
                    {
                        assignmentFailures.AppendLine($"{toProp.Name}:{toProp.PropertyType.Name},{ex}");
                    }
                }
            }

            return assignmentFailures.ToString();

        }

        public static object GetTypedValue(this PropertyInfo fromProp, PropertyInfo toProp, object fromObj, object toObj)
        {
            var fromValue = fromProp.GetValue(fromObj);
            return fromValue.Convert(toProp.PropertyType);
        }

        public static object Convert(this object fromValue, Type toType)
        {
            if (fromValue == null)
                return toType.GetDefault();
            return fromValue.GetType().TypeIsEquivalent(toType) ? fromValue : 
                fromValue.InternalConvert(toType);
        }

        private static object InternalConvert(this object fromValue, Type toType)
        {
            return toType.IsAssignableFrom(typeof(string)) ? fromValue.ToString() : System.Convert.ChangeType(fromValue, toType);
        }

        public static object CreateInstance(this Type t)
        {
            var obj = t.Assembly.CreateInstance(t.FullName);
            if (obj == null)
                throw new Exception($"Could not create object of type {t.FullName}");
            return obj;
        }
    }
}
