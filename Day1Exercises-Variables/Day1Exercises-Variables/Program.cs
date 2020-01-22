using System;

namespace Day1Exercises_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1;
            int i = 1;
            int j = 5;
            double answer2, answer3, answer4, answer5, answer6, answer7;
            //answer 1
            Console.Write("Write any sentence: ");
            answer1 = Console.ReadLine();
            Console.WriteLine(answer1);
            //answer 2
            Console.WriteLine("Enter any number: ");
            answer2 =double.Parse(Console.ReadLine());
            Console.WriteLine(answer2 + i);
            //answer 3
            Console.WriteLine("Enter any number:");
            answer3 = double.Parse(Console.ReadLine());
            Console.WriteLine(answer3 + j);
           //answer 4
            Console.WriteLine("Enter any number:");
            answer4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            answer5 = double.Parse(Console.ReadLine());
            Console.WriteLine(answer4 + answer5);
            //answer 5
            Console.WriteLine("Enter another number again: ");
            answer6 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a final number: ");
            answer7 = double.Parse(Console.ReadLine());
            Console.WriteLine("The product of the last two numbers is: " + answer6 * answer7);
        }
    }
}
