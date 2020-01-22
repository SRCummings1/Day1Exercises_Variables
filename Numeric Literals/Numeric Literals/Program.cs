using System;

namespace Numeric_Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int userNumber = -1;

        while ( userNumber != x)
            {
                Console.WriteLine("Guess a number!");
                userNumber = int.Parse(Console.ReadLine());

                //bool result = (userNumber < x);
                //Console.WriteLine($"User Number {userNumber} is less than 6: {result}");
                Console.WriteLine("You guessed the Number: {x} ");
            
            }

        }
    }
}
