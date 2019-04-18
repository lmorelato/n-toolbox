using System.Text.RegularExpressions;

namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool IsValidEmailAddress(this string s)
        {
            const string EmailRegex = @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?";
            var regex = new Regex(EmailRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return !string.IsNullOrWhiteSpace(s) && regex.IsMatch(s);
        }
    }
}
