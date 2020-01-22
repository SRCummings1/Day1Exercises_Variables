using System;

namespace mailingAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, City, Street;
            int  Housenumber, Zipcode;
            

            Console.ForegroundColor
            = ConsoleColor.Magenta;
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("When were you born?");

            DateTime dt = Convert.ToDateTime(Console.ReadLine());

            int year = dt.Year;
            Console.WriteLine("What is your City");
            City = Console.ReadLine();
            Console.WriteLine("What is your Street?");
            Street = Console.ReadLine();
            Console.WriteLine("What is your House number?");
            Housenumber =int.Parse(Console.ReadLine());
            Console.WriteLine("What is your zipcode?");
            Zipcode = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0},you were born on {1} your adress is {2} {3} {5}  your zipcode is {4}", Name, year, City, Street, Zipcode, Housenumber); 

            //Console.WriteLine(DateTime.Today.Year - birthDay.Year);

        }
    }
}
