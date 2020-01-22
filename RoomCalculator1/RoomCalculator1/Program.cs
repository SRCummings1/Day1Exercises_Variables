using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RoomCalculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, length;
            string LengthString, WidthString;
            Console.WriteLine("This program calculates the area of a room in square feet.");
            Console.WriteLine("Enter the Length of the room.");
            LengthString = Console.ReadLine();
            length = double.Parse(LengthString);
            Console.WriteLine("Enter the Width of the room.");
            WidthString = Console.ReadLine();
            width = double.Parse(WidthString);​
            double total = length * width;
            Console.WriteLine("The area of the room is " + total + " square feet.");
            Console.ReadKey();​
        }
    }
}