namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string FormatWith(this string f, params object[] values)
        {
            if (f.IsNullOrWhiteSpace() || values.Length == 0)
            {
                return f;
            }

            return string.Format(f, values);
        }
    }
}
