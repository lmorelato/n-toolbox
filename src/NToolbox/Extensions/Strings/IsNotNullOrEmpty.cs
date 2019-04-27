namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static bool IsNotNullOrEmpty(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }
    }
}
