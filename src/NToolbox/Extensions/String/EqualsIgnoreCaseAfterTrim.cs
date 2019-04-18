namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool EqualsIgnoreCaseAfterTrim(this string a, string b)
        {
            return EqualsIgnoreCase(a.SafeTrim(), b.SafeTrim());
        }
    }
}
