namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static string ToValueIfEmptyOrWhiteSpace(this string s, string valueIfNullOrWhiteSpace)
        {
            return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s) ? valueIfNullOrWhiteSpace : s;
        }
    }
}
