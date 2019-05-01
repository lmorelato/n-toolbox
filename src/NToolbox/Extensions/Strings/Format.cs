namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string Format(this string f, params object[] values)
        {
            return string.Format(f, values);
        }
    }
}
