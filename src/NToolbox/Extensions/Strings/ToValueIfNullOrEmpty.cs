namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string ToValueIfNullOrEmpty(this string s, string value)
        {
            return string.IsNullOrEmpty(s) ? value : s;
        }
    }
}
