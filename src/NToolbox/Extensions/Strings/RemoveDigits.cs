using System.Linq;

namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string RemoveDigits(this string text)
        {
            return new string(text.ToCharArray().Where(x => !char.IsDigit(x)).ToArray());
        }
    }
}