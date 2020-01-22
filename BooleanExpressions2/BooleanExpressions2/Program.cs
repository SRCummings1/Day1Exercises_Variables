using System;

namespace BooleanExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
                double num1 = 21.65;
                float num2 = 3.14f;
                int num3 = 42;

                bool isEqual = (num1 == (num2 + num3));
            Console.WriteLine($"{num1} == {num2}  {num3}) = {isEqual}");

            string var1 = "panda";
            string var2 = "owl";
            bool isEqual2 = (var1 == var2);
            Console.WriteLine($"isEqual2 == {isEqual2}");

            var2 = "Padna";
            isEqual2 = (var1 == var2);
            Console.WriteLine($"isEqal2 == {isEqual2}");
            
            bool isEqual3 =! ((num2> num3) && (num1 > num2));
            Console.WriteLine(isEqual3);
        }
    }
}
