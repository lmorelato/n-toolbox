﻿using System.Linq;

namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string RemoveDigits(this string text)
        {
            if (text.IsNullOrWhiteSpace())
            {
                return text;
            }

            return new string(text.ToCharArray().Where(x => !char.IsDigit(x)).ToArray());
        }
    }
}