using System;

namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
