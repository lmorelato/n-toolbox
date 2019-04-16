namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool IsNotNullOrWhiteSpace(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }
    }
}
