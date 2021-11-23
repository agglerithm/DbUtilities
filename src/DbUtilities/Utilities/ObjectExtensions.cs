using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            props.AssignClassChildren(obj, flattenedObject);

        }

        public static void AssignClassChildren(this PropertyInfo[] props, object obj, object flattenedObject)
        {
            var flattenedProps = flattenedObject.GetType().GetProperties();
            foreach (var classProp in props)
            {
                var matchingProp = flattenedProps.First(p => p.Name == classProp.Name);
                if (classProp.GetType().IsClass)
                {
                    var child = classProp.PropertyType.CreateInstance();
                    classProp.SetValue(obj, child);
                    child.GetType().GetProperties().AssignClassChildren(child, flattenedObject);
                }
                else
                {
                    classProp.SetValue(obj,matchingProp.GetValue(flattenedObject));
                }
            }
            
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
