namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string SafeTrim(this string s1)
        {
            return string.IsNullOrEmpty(s1) ? s1 : s1.Trim();
        }
    }
}
