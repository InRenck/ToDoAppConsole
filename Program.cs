using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>(); // List to store tasks

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== TO-DO LIST APP =====");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option! Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string? task = Console.ReadLine(); // Allow null for task input

        // Null check before adding to the list
        if (!string.IsNullOrEmpty(task))
        {
            tasks.Add(task);
            Console.WriteLine("Task added! Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("Invalid task! Task cannot be empty. Press Enter to continue.");
        }
        Console.ReadLine();
    }

    static void ViewTasks()
    {
        Console.WriteLine("\n===== Your Tasks =====");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks yet.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        Console.WriteLine("\nPress Enter to continue.");
        Console.ReadLine();
    }

    static void RemoveTask()
    {
        ViewTasks();
        Console.Write("\nEnter task number to remove: ");
        if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
        {
            tasks.RemoveAt(taskIndex - 1);
            Console.WriteLine("Task removed! Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("Invalid task number! Press Enter to continue.");
        }
        Console.ReadLine();
    }
}
