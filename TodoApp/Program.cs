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
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        DeleteTask();
                        break;
                    case "3":
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

        static void DeleteTask()
        {
            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index > 0 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine("Task deleted.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
