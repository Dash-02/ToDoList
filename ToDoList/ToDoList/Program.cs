using System;
using System.Collections.Generic;

namespace ToDoList 
{
    class Program
    {
        enum UserChoice
        {
            AddTask = 1,
            DeleteTask,
            Exit
        }
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
            while (true)
            {
                if (toDoList.Count > 0)
                {
                    Console.WriteLine("To-do List:");

                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("- " + toDoList[i]);
                    }

                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You currently have no tasks in your To-do list.");
                    Console.WriteLine("");
                }

                Console.WriteLine("1. Add task");
                Console.WriteLine("2. Delete task");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());
                if (choice == (int)UserChoice.AddTask)
                {
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added successfully!");
                }
                else if (choice == (int)UserChoice.DeleteTask)
                {
                    if (toDoList.Count > 0)
                    {
                        Console.WriteLine("Enter the number of the task you want to delete:");

                        for (int i = 0; i < toDoList.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
                        }
                        int taskNum = int.Parse(Console.ReadLine());
                        taskNum--;

                        if (taskNum >= 0 && taskNum < toDoList.Count)
                        {
                            toDoList.RemoveAt(taskNum);
                            Console.Clear();
                            Console.WriteLine("Task deleted successfully!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid task number.");
                            Console.WriteLine("");
                        }
                    }
                }
                else if (choice == (int)UserChoice.Exit)
                {
                    break;
                }
            }
        }
    }
}
