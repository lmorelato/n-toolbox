namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static bool EqualsIgnoreCaseAfterTrim(this string a, string b)
        {
            return EqualsIgnoreCase(a.SafeTrim(), b.SafeTrim());
        }
    }
}
