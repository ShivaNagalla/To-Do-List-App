using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static List<string> tasks = new List<string>();
        
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("To-Do List Application");
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
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter a new task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
            Console.ReadLine();
        }

        static void ViewTasks()
        {
            Console.WriteLine("Your Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            Console.ReadLine();
        }

        static void RemoveTask()
        {
            ViewTasks();
            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
            {
                tasks.RemoveAt(taskIndex - 1);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            Console.ReadLine();
        }
    }
}
