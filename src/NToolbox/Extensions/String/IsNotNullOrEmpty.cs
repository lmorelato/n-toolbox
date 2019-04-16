namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static bool IsNotNullOrEmpty(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }
    }
}
