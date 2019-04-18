﻿using System;

namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool ContainsIgnoreCaseAfterTrim(this string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                return false;
            }

            return s1.SafeTrim().IndexOf(s2.SafeTrim(), StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}