using System;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<para, return type>

            Func<int, int> square = number => number * number;

            Func<int, int, int> multipleTwoNumber = (a, b) => a * b;

            Console.WriteLine(square(4));
            Console.WriteLine(multipleTwoNumber(2,3));
        }
    }
}
