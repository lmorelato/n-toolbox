using System;
using System.Collections.Generic;
using System.Linq;

namespace NToolbox.Extensions.Enumerables
{
    public static partial class EnumerableExtensions
    {
        private static readonly string DefaultSeparator = ",";

        /// <summary>
        /// Joins a collection by comma
        /// </summary>
        /// <typeparam name="TSource">Generic Collection Type</typeparam>
        /// <param name="values">Generic collection</param>
        /// <returns>joined string by comma</returns>
        public static string Join<TSource>(this IEnumerable<TSource> values)
        {
            return values.JoinBy(DefaultSeparator);
        }

        /// <summary>
        /// Filters a collection by a predicate then joins it by comma
        /// </summary>
        /// <typeparam name="TSource">Generic Collection Type</typeparam>
        /// <param name="values">Generic collection</param>
        /// <param name="predicate">Predicate function</param>
        /// <returns>joined string by comma</returns>
        public static string Join<TSource>(this IEnumerable<TSource> values, Func<TSource, object> predicate)
        {
            return values.JoinBy(predicate, DefaultSeparator);
        }

        /// <summary>
        /// Joins a collection by specified separator
        /// </summary>
        /// <typeparam name="TSource">Generic Collection Type</typeparam>
        /// <param name="values">Generic collection</param>
        /// <param name="separator">Separator to be applied to the result</param>
        /// <returns>joined string by specified separator</returns>
        public static string JoinBy<TSource>(this IEnumerable<TSource> values, string separator)
        {
            return string.Join(separator, values);
        }

        /// <summary>
        /// Joins a collection by specified separator
        /// </summary>
        /// <typeparam name="TSource">Generic Collection Type</typeparam>
        /// <param name="values">Generic collection</param>
        /// <param name="predicate">Predicate function</param>
        /// <param name="separator">Separator to be applied to the result</param>
        /// <returns>joined string by specified separator</returns>
        public static string JoinBy<TSource>(this IEnumerable<TSource> values, Func<TSource, object> predicate, string separator)
        {
            return string.Join(separator, values.Select(predicate));
        }
    }
}