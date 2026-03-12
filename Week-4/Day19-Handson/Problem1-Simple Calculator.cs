using System;

namespace ConsoleApp35
{
    class Calculator
    {
        public int Add(int a , int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int addition = calc.Add(num1, num2);
            int subtraction = calc.Subtract(num1, num2);

            Console.WriteLine("Addition = " + addition);
            Console.WriteLine("Subtraction= " + subtraction);

        }
    }
}
