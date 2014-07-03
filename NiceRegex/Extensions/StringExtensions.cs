using System.Collections.Generic;

namespace NiceRegex.Extensions
{
    internal static class StringExtensions
    {
        public static string StringJoin<T>(this IEnumerable<T> items, string separator = "")
        {
            return string.Join(separator, items);
        }
    }
}
