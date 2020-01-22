using System;

namespace Day_1___Boolean_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x = 1, y = 2;

            result = (x == y);
            Console.WriteLine($"Equal to Operator: {result}");

            result = (x > y);
            Console.WriteLine($"Greater than Operator: {result}");

            result = (x <= y);
            Console.WriteLine($"Less that or Equal Operator: {result}");

            result = (x!= y);
            Console.WriteLine($"Not Equal to Operator: {result}");

            result = (x == y) && (x > y);
            Console.WriteLine($"Equal to Operator and x is Greater than Operator: {result}");

        }
    }
}
