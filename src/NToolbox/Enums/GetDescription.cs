using System;
using System.ComponentModel;
using System.Linq;

namespace NToolbox.Enums
{
    public static partial class EnumExtensions
    {
        public static string GetDescription(this Enum valor)
        {
            if (valor == null)
            {
                throw new ArgumentNullException(nameof(valor));
            }

            var field = valor.GetType().GetField(valor.ToString());
            if (field == null)
            {
                return valor.ToString();
            }

            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes.First().Description : valor.ToString();
        }
    }
}
