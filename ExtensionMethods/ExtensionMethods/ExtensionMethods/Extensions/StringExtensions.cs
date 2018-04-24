using System;
using System.Linq;

namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static string GetFirstNWords(this string str, int n)
        {
            if (n <= 0)
                throw new System.ArgumentOutOfRangeException("Number of words cannot be less than or equal to zero.");

            var words = str.Split(' ');

            return string.Join(" ", words.Take(n));
        }
    }
}
