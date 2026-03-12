using System;

namespace ConsoleAppBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empName;
            double salary;
            int experience;

            Console.Write("Enter Name: ");
            empName = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());

            // Check salary
            if (salary < 0)
            {
                Console.WriteLine("Invalid Salary! Salary cannot be negative.");
                return;
            }

            Console.Write("Enter Experience: ");
            experience = int.Parse(Console.ReadLine());

            // Check experience
            if (experience < 0)
            {
                Console.WriteLine("Invalid Experience! Experience cannot be negative.");
                return;
            }

            double bonusPercent;

            if (experience < 2)
            {
                bonusPercent = 0.05;
            }
            else if (experience >= 2 && experience <= 5)
            {
                bonusPercent = 0.10;
            }
            else
            {
                bonusPercent = 0.15;
            }

            double bonus = salary * bonusPercent;
            double finalSalary = salary + bonus;

            Console.WriteLine("Employee: " + empName);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Final Salary: " + finalSalary);
        }
    }
}