using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Add_Taskk_Screen
    {
        public static void Show_Add_Task_Screen( Task_Mangment_System Sys)
        {
            Console.WriteLine("Entre Task Deatils : ");
            string content = Console.ReadLine();
            Sys.Add_Task(content);
            Console.WriteLine("Added Successfly");
            Console.ReadKey();
        }
    }
}
