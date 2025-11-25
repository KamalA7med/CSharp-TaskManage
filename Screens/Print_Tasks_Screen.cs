using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Print_Tasks_Screen
    {
        public static void Print_Tasks(List<Task>Tasks,string Message,string Date_State)
        {
            Console.WriteLine($"                   {Message}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"|{"Task Number".PadRight(13)}|{"Taks".PadRight(30)} | {$"{Date_State} Date".PadRight(30)}|");
            Console.WriteLine("-----------------------------------------------------------------------------");
            int Task_Counter = 1;
            foreach (var task in Tasks)
            {
                Console.WriteLine($"|{Task_Counter.ToString().PadRight(13)}|{task.Details.PadRight(30)} | {task.Time.ToString().PadRight(30)}|");
                ++Task_Counter;
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
