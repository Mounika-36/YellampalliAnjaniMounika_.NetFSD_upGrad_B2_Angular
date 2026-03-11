using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.Write("Enter First Number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Operator (+, -, *, /): ");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }
        }
    }
}