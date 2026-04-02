using System;
using System.Collections.Generic;

namespace StudentRecordSystem
{
  
    public record Student(int RollNo, string Name, string Course, int Marks);

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int choice;

            do
            {
                Console.WriteLine("\n Student Record Management System ");
                Console.WriteLine("1. Add Students");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student by Roll Number");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

               
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudents(students);
                        break;

                    case 2:
                        DisplayStudents(students);
                        break;

                    case 3:
                        SearchStudent(students);
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }

        static void AddStudents(List<Student> students)
        {
            Console.Write("Enter number of students: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for student {i + 1}:");

                int rollNo;
                while (true)
                {
                    Console.Write("Enter Roll Number: ");
                    if (int.TryParse(Console.ReadLine(), out rollNo))
                        break;
                    Console.WriteLine("Invalid Roll Number! Try again.");
                }

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                int marks;
                while (true)
                {
                    Console.Write("Enter Marks: ");
                    if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                        break;
                    Console.WriteLine("Invalid Marks! Enter between 0 and 100.");
                }

                students.Add(new Student(rollNo, name, course, marks));
            }

            Console.WriteLine("Students added successfully!");
        }

       
        static void DisplayStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            Console.WriteLine("\nStudent Records:");
            foreach (var s in students)
            {
                Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
            }
        }

        static void SearchStudent(List<Student> students)
        {
            Console.Write("Enter Roll Number to search: ");
            if (!int.TryParse(Console.ReadLine(), out int searchRoll))
            {
                Console.WriteLine("Invalid Roll Number!");
                return;
            }

            var student = students.Find(s => s.RollNo == searchRoll);

            Console.WriteLine("\nSearch Result:");
            if (student != null)
            {
                Console.WriteLine("Student Found:");
                Console.WriteLine($"Roll No: {student.RollNo} | Name: {student.Name} | Course: {student.Course} | Marks: {student.Marks}");
            }
            else
            {
                Console.WriteLine("Student record not found.");
            }
        }
    }
}