using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
     delegate bool action(Task_Mangment_System Sys,int TaskNumber);
    internal class Program
    {
       
        public static void Print_Choices()
        {
            Console.WriteLine("Welcom ");
            Console.WriteLine("---------------------");
            Console.WriteLine("[1] Show Tasks ");
            Console.WriteLine("[2] Add Task ");
            Console.WriteLine("[3] Complete Task ");
            Console.WriteLine("[4] Remove Task ");
            Console.WriteLine("[5] Update Task ");
            Console.WriteLine("[6] Completed Tasks ");
            Console.WriteLine("[7] Exist ");
            Console.WriteLine("---------------------");
            
        }

        public static void Implement_Choice(Task_Mangment_System task_Mangment_System,int choice)
        {
            
            
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Print_Tasks_Screen.Print_Tasks(task_Mangment_System.Tasks,"UnComeleted Tasks ","Adding");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Add_Taskk_Screen.Show_Add_Task_Screen(task_Mangment_System);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        DealwithTask_Screen.Show_DealwithTask_Screen(Complete_Task,task_Mangment_System, "Complete Task Screen");
                        FileHandler.Save_Changes(task_Mangment_System.Tasks);
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        DealwithTask_Screen.Show_DealwithTask_Screen(Remove_Task, task_Mangment_System, "Remove TaskScreen");
                        FileHandler.Save_Changes(task_Mangment_System.Tasks);
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        DealwithTask_Screen.Show_DealwithTask_Screen(Update_Task, task_Mangment_System, "Update Task Screen");
                        FileHandler.Save_Changes(task_Mangment_System.Tasks);
                        break;
                    }

                case 6:
                    {
                        Console.Clear();
                        Print_Tasks_Screen.Print_Tasks(FileHandler.Get_Tasks_From_File(FileHandler.Completed_Tasks_File), "Completed Tasks","Completing");
                        break;
                    }
            }
        }
        public static bool Complete_Task(Task_Mangment_System Sys, int TaskNumber) {
            return Sys.CompeleteTask(TaskNumber);        
        }
        public static bool Remove_Task(Task_Mangment_System Sys, int TaskNumber)
        {
            return Sys.Remove_Task(TaskNumber);
        }

        public static bool Update_Task(Task_Mangment_System Sys, int TaskNumber)
        {
            Console.WriteLine("Enter New Task Details :");
            string NewContent=Console.ReadLine();
            return Sys.UpdateTask(TaskNumber, NewContent);
        }

        static void Main(string[] args)
        {
            int option = 0;
            Task_Mangment_System task_Mangment_System = new Task_Mangment_System();
            while (true)
            {
                Console.Clear();
                Print_Choices();
                Console.Write("Entre Your Choice : ");
                option = int.Parse(Console.ReadLine());    
                Implement_Choice(task_Mangment_System, option);
                if (option == 7) { return; }

            }

        }
    }
}
