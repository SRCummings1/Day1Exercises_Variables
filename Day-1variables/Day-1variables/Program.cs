using System;

namespace Day_1variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit cast 
            int i = 0;
            double number = i;

            //explicit cast 
            double number2 = 0.0;
                i = (int)number2;
            //input 
            //1.Request
            Console.WriteLine("Give me a number");
            //2.Retrieve
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number");
            int number3 = int.Parse(Console.ReadLine());
            //processing
            int sum = number1 + number3;
            //output
            Console.WriteLine(sum);
            Console.WriteLine("{0} +{1} = {2}", number1, number3, sum);
            Console.WriteLine(number1 + " + "+ number3 + " = "+ sum);
            Console.WriteLine($"{number1} +{number3} = {sum}");


        }
    }
}
