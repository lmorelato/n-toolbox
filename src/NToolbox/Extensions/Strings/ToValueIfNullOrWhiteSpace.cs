namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string ToValueIfNullOrWhiteSpace(this string s, string value)
        {
            return string.IsNullOrWhiteSpace(s) ? value : s;
        }
    }
}
