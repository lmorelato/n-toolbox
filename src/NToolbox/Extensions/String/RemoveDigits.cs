using System.Linq;

namespace NToolbox.Extensions.String
{
    public static partial class Strings
    {
        public static string RemoveDigits(this string text)
        {
            return new string(text.ToCharArray().Where(x => !char.IsDigit(x)).ToArray());
        }
    }
}