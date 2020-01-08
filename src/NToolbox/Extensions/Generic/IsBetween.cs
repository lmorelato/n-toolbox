using System.Collections.Generic;

namespace NToolbox.Extensions.Generic
{
    public static partial class GenericExtensions
    {
        // see @ https://stackoverflow.com/questions/5023213/is-there-a-between-function-in-c
        public static bool IsBetween<T>(this T item, T start, T end)
        {
            return (Comparer<T>.Default.Compare(item, start) >= 0) &&
                   (Comparer<T>.Default.Compare(item, end) <= 0);
        }
    }
}
