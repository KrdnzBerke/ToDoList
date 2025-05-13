using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the to do list program");
            List<string> taskList= new List<string>();

            string option = "";

            while(option != "e")
            {
                Console.WriteLine("what would you like");
                Console.WriteLine("enter 1 add a task to the list");
                Console.WriteLine("enter 2 to remove a task from the list");
                Console.WriteLine("enter 3 to view the list");
                Console.WriteLine("enter e to exit the program");

                option=Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("please enter the name of the task to add to the list");
                    string task =Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("task added to the list");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + "  :  " + taskList[i]);
                    }
                    Console.WriteLine("please enter the number of the task to remove from the list");
                    int taskNumber=Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);

                }
                else if (option == "3")
                {
                    Console.WriteLine("exiting program");
                }
                else
                {
                    Console.WriteLine("invalid option try again");
                }

            }
            Console.WriteLine("thank you ");
        }
    }
}
