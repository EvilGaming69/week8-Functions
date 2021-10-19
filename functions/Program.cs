using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta omanimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            SayHello(userName, userAge);
        }
        private static void SayHello(string someName, int someNumber)
        {
            Console.WriteLine($"Hi there! {someName}!");
            Console.WriteLine($"Oled sündinud aastal {2021 - someNumber}.");
        }
    }
}
