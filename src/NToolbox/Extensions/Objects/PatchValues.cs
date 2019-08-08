using System;
using System.Collections.Generic;

namespace NToolbox.Extensions.Objects
{
    public static partial class ObjectExtensions
    {
        public static void PatchValues(this object obj, Dictionary<string, object> values)
        {
            foreach (var pair in values)
            {
                var propertyInfo = obj.GetType().GetProperty(pair.Key);
                if (propertyInfo == null)
                {
                    continue;
                }

                object value;
                if (propertyInfo.PropertyType.IsEnum)
                {
                    value = Enum.ToObject(propertyInfo.PropertyType, pair.Value);
                }
                else
                {
                    value = Convert.ChangeType(pair.Value, propertyInfo.PropertyType);
                }

                propertyInfo.SetValue(obj, value, null);
            }
        }
    }
}
