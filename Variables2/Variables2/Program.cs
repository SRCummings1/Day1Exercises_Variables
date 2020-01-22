using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, city, ssn;
            char gender;
            DateTime birthday;

            //request input

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            
            Console.Write("City:");
            city = Console.ReadLine();
             
            Console.Write("Gender:");
            gender = Console.ReadLine()[0];
            Console.Write("SSN:");
            ssn = Console.ReadLine();
            Console.Write("Birthday: (mm/dd/yyyy)");
            birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Hi, {name} ({gender})! You're born from {city} on {birthday} and your SSN is {ssn} ");




        }
    }
}
