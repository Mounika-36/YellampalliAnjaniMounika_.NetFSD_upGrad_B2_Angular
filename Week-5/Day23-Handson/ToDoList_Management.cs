using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("\nTo-Do List Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            // Validate menu input
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddTask(tasks);
                    break;

                case 2:
                    ViewTasks(tasks);
                    break;

                case 3:
                    RemoveTask(tasks);
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 4);
    }

    // 🔹 Add Task
    static void AddTask(List<string> tasks)
    {
        Console.Write("Enter task: ");
        string task = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(task))
        {
            Console.WriteLine("Task cannot be empty.");
            return;
        }

        tasks.Add(task);
        Console.WriteLine("Task added!");
    }

    // 🔹 View Tasks
    static void ViewTasks(List<string> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    // 🔹 Remove Task
    static void RemoveTask(List<string> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to remove.");
            return;
        }

        Console.Write("Enter task number to remove: ");
        string input = Console.ReadLine();

        int index;
        if (!int.TryParse(input, out index))
        {
            Console.WriteLine("Invalid input. Enter a number.");
            return;
        }

        // Convert to 0-based index
        index = index - 1;

        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }

        Console.WriteLine($"Removed: {tasks[index]}");
        tasks.RemoveAt(index);
    }
}






