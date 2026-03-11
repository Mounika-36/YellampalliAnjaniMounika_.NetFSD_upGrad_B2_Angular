namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empName;
            int experience;
            double salary;
            Console.WriteLine("Enter user name : ");
            empName = Console.ReadLine();
            Console.WriteLine("Enter user Experience : ");
            experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter user Salary : ");
            salary = double.Parse(Console.ReadLine());
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
            double finalSalary = bonus > 0 ? salary + bonus : salary;

            // Display result
            Console.WriteLine("Employee: " + empName);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Final Salary: " + finalSalary);
        }
    }
}
