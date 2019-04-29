namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string Format(this string format, params object[] values)
        {
            return string.Format(format, values);
        }
    }
}
