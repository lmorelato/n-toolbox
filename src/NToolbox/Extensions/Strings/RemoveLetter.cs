using System.Linq;

namespace NToolbox.Extensions.Strings
{
    public static partial class StringExtensions
    {
        public static string RemoveLetter(this string text)
        {
            return new string(text.ToCharArray().Where(x => !char.IsLetter(x)).ToArray());
        }
    }
}