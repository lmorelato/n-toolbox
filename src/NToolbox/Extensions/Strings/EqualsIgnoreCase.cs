using System;

namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
