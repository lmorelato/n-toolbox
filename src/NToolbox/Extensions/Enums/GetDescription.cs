using System;
using System.ComponentModel;
using System.Linq;

namespace NToolbox.Extensions.Enums
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
            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length == 0)
            {
                return valor.ToString();
            }

            return attributes.First().Description;
        }
    }
}
