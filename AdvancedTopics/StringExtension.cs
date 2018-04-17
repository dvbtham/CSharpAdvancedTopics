using System;
using System.Linq;

namespace AdvancedTopics
{
    public static class StringExtension
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0) throw new ArgumentOutOfRangeException("numberOfWords should be greater than 0");
            if (numberOfWords == 0) return "";

            var result = str.Split(' ');

            if (numberOfWords > result.Length) return str;

            return string.Join(" ", result.Take(numberOfWords)) + " ...";
        }
    }
}