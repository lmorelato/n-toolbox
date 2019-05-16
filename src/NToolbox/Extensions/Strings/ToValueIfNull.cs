namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string ToValueIfNull(this string s, string value)
        {
            return string.IsNullOrEmpty(s) ? value : s;
        }
    }
}
