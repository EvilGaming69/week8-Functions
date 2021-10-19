using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta  teine number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+','-','*' või '/");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch (userOperation)
            {
                case '+':
                    AddTwoNumber(firstNumber, secondNumber);
                    break;
                case '/':
                    DivideTwoNumbers(firstNumber, secondNumber);
                    break;
                case '-':
                    SubstractTwoNumbers(firstNumber, secondNumber);
                    break;
                case '*':
                    MultiplyTwoNumbers(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("vale tehe");
                    break;
            }
            
        }
        
        private static void AddTwoNumber(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        private static void DivideTwoNumbers(int x, int y)
        {
            int result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void SubstractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
    }
}
