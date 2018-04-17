using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4 };

            numbers.Average();

            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());

            var course = "C# Advanced Topics: Take Your C# Skills to the Next Level";
            Console.WriteLine(course.Shorten(12));
        }
    }
}
