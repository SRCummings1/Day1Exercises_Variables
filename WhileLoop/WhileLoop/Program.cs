using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Prompt
            Console.WriteLine("Enter a number please:");
            
            //Receive
            int userNum = int.Parse(Console.ReadLine());
            while (userNum > 0)
            {
                Console.WriteLine("Hello World! " + userNum);
                userNum--; //userNumber = uswerNumber -1
            }
            }
    }
}
