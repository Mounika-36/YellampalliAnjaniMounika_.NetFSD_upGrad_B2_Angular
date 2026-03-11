using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int studentMarks;

            Console.WriteLine("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter Student Marks: ");
            studentMarks = int.Parse(Console.ReadLine());

            // Check for invalid input
            if (studentMarks < 0 || studentMarks > 100)
            {
                Console.WriteLine("Invalid Marks! Please enter marks between 0 and 100.");
            }
            else
            {
                string grade;
                // Determine grade using if-else

                if (studentMarks >= 85)
                {
                    grade = "A";
                }
                else if (studentMarks >= 70)
                {
                    grade = "B";
                }
                else if (studentMarks >= 55)
                {
                    grade = "C";
                }
                else if (studentMarks >= 40)
                {
                    grade = "D";
                }
                else
                {
                    grade = "Fail";
                }

                // Display result
                Console.WriteLine("Student: " + studentName);
                Console.WriteLine("Grade: " + grade);
            }
        }
    }
}