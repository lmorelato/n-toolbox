﻿namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string Truncate(this string s, int maxLength)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            if (maxLength < 0)
            {
                return string.Empty;
            }

            if (s.Length > maxLength)
            {
                return s.Substring(0, maxLength);
            }

            return s;
        }
    }
}
