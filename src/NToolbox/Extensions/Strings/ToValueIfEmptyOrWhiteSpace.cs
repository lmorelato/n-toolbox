namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string ToValueIfEmptyOrWhiteSpace(this string s, string valueIfNullOrWhiteSpace)
        {
            return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s) ? valueIfNullOrWhiteSpace : s;
        }
    }
}
