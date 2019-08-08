using System.Collections;
using System.Linq;
using System.Reflection;
using NToolbox.Extensions.Strings;

namespace NToolbox.Extensions.Objects
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// Shallow Trim all strings properties from an object, including custom types and lists if the flag is specified.
        /// see @ https://stackoverflow.com/questions/35234810/trim-spaces-in-a-object-recursively-using-reflection
        /// </summary>
        /// <param name="obj">Object to be trimmed</param>
        /// <param name="includeCustomTypesAndLists">Trim all strings properties from custom types and lists</param>
        public static void TrimSpaces(this object obj, bool includeCustomTypesAndLists = false)
        {
            if (obj != null)
            {
                TrimStringProperties(obj);
                if (includeCustomTypesAndLists)
                {
                    TrimCustomTypes(obj);
                    TrimLists(obj);
                }
            }
        }

        private static void TrimStringProperties(object obj)
        {
            var stringProperties = obj
                .GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.PropertyType == typeof(string) && 
                            p.CanWrite && 
                            p.CanRead);

            foreach (var stringProperty in stringProperties)
            {
                var currentValue = (string)stringProperty.GetValue(obj, null);
                var value = currentValue.SafeTrim();
                stringProperty.SetValue(obj, value == string.Empty ? null : value, null);
            }
        }

        private static void TrimCustomTypes(object obj)
        {
            var customTypes = obj
                .GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.PropertyType?.FullName != null && 
                            (!p.PropertyType.FullName.StartsWith("System") &&
                             !p.GetType().IsPrimitive && p.GetType().IsClass &&
                             p.GetIndexParameters().Length == 0));

            foreach (var customType in customTypes)
            {
                customType.GetValue(obj).TrimSpaces();
            }
        }

        private static void TrimLists(object obj)
        {
            var listTypes = obj
                .GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(p => p.GetValue(obj, null) as ICollection)
                .Where(p => p != null);

            foreach (var list in listTypes)
            {
                foreach (var item in list)
                {
                    item.TrimSpaces();
                }
            }
        }
    }
}
