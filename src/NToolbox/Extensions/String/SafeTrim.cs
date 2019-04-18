namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static string SafeTrim(this string s1)
        {
            return string.IsNullOrEmpty(s1) ? s1 : s1.Trim();
        }
    }
}
