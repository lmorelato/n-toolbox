using System;

namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool ContainsIgnoreCase(this string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                return false;
            }

            return s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}