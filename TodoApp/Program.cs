using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nTodo List:");
                ShowTasks();

                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Exit");
                Console.Write("Choose: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter new task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added.");
        }
    }
}