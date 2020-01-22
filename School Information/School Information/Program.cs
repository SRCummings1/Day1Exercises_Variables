using System;

namespace School_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            String userResponse = "y";
            while (userResponse == "y") 
            {
                string Name, DOB, Class, GPA, universityName, startDate;

                Console.WriteLine("What is your name?");
                Name = Console.ReadLine();
                Console.WriteLine("What is your Date of birth?");
                DOB = Console.ReadLine();
                Console.WriteLine("What class are you taking?");
                Class = Console.ReadLine();
                Console.WriteLine("What is your GPA?");
                GPA = Console.ReadLine();
                Console.WriteLine("What is your University?");
                universityName = Console.ReadLine();
                Console.WriteLine("When is your start date?");
                startDate = Console.ReadLine();

                Console.WriteLine("Your name is {0}. Your birthdate is {1}.Your class is {2} and your GPA is {3} at {4} and you start on {5}", Name, DOB, Class, GPA, universityName, startDate);
                Console.WriteLine("Would you like to continue y/n");
                userResponse = Console.ReadLine().ToLower();

                userResponse = "";
                while (userResponse != "y" && userResponse != "n") ;
            }    
            }
    }
}
