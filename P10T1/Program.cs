using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10T1
{
    internal class Program
    {
        const int nrtask = 10;
        static void Main(string[] args)
        {
            String[] todoList = new string[nrtask];
            int nrEl = 0;
            int option = DisplayOptions();
            while (option != 4)
            {
                switch (option)
                {
                    case 1:
                        AddTast(todoList, ref nrEl);
                        break;
                    case 2:
                        DisplayTasks(todoList, nrEl);
                        break;
                    case 3:
                        RemoveTask(todoList, ref nrEl);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine();
                option = DisplayOptions();
            }
            Console.WriteLine("Closing program") ;
            Console.ReadLine();
        }
        static int DisplayOptions()
        {
            int option;
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Display tasks");
            Console.WriteLine("3. Remove task");
            Console.WriteLine("4. Quit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void AddTast(String[] todoList, ref int nrEl)
        {
            string task;
            if (nrEl == nrtask)
            {
                Console.WriteLine("There is no space to add another tast");
            }
            else
            {
                Console.Write("Enter the task to add: ");
                task = Console.ReadLine().ToUpper();
                todoList[nrEl] = task;
                Console.WriteLine("Task added successfully");
                nrEl++;
            }
        }
        static void DisplayTasks(String[] todoList, int nrEl)
        {
            if (nrEl == 0)
            {
                Console.WriteLine("Tast list is empty");
            }
            else
            {
                for (int i = 0; i < nrEl; i++)
                {
                    Console.Write("{0} ", todoList[i]);
                }
                Console.WriteLine();
            }
        }
        static void RemoveTask(String[] todoList, ref int nrEl)
        {
            string wanted;
            if (nrEl == 0)
            {
                Console.WriteLine("There are no tasks in your list");
            }
            else
            {
                Console.Write("Enter the task you want to remove:");
                wanted = Console.ReadLine().ToUpper();
               int index= FindTask(todoList, nrEl, wanted);
                if (index == -1)
                {
                    Console.WriteLine("Task could not be found");
                }
                else
                {
                    for (int i = index; i <= nrEl-2; i++)
                    {
                        todoList[i] = todoList[i+1];
                    }
                    nrEl--;
                    Console.WriteLine("Task deleted successfully");
                }
            }
        }
        static int FindTask(String[] todoList, int nrEl, string wanted)
        {
            int index = -1;
            if (nrEl == 0)
            {
                Console.WriteLine("There are no tasks to remove in your list");
            }
            else
            {
                for (int i = 0; i < nrEl; i++)
                {
                    if (todoList[i] == wanted)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }
    }
}
