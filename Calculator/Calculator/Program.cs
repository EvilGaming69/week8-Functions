using System;

namespace Calculator
{
    class Program
    {
        

        public static string OperatingSystem { get; private set; }

        static void Main(string[] args)
        {
            double firstnum;
            double secondnumber;
            double answer;
            string ops;
            Console.WriteLine("\t\t\tConsole Calculator in C#\r");
            Console.WriteLine("\t\t\t------------------------\r");

            Console.WriteLine("Enter first number\n");
            firstnum = double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an Operator: (+, -, /, %, )\n");
            OperatingSystem = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter second number\n");
            secondnumber = Double.Parse(Console.ReadLine());

            if (OperatingSystem == "+")
            {
                answer = firstnum + secondnumber;
                Console.Write(answer);
            }
            if (OperatingSystem == "-")
            {
                answer = firstnum - secondnumber;
                Console.Write(answer);
            }
            if (OperatingSystem == "*")
            {
                answer = firstnum * secondnumber;
                Console.Write(answer);
            }
            if (OperatingSystem == "/") 
            {
                answer = firstnum / secondnumber;
                Console.Write(answer);
            }
            if (OperatingSystem == "%")
            {
                answer = firstnum % secondnumber;
                Console.Write(answer);
            }

            
        }
    }
}
