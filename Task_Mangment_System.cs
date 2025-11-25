using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Task_Mangment_System
    {
        public List<Task> Tasks { get; }
        public Task_Mangment_System()
        {
            Tasks = FileHandler.Get_Tasks_From_File(FileHandler.Tasks_File);
        }
        private bool Check_Valid_Task_Number(int TaskNumber)
        {
            if (TaskNumber > Tasks.Count || TaskNumber < 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void Add_Task(string content)
        {
           Tasks.Add(new Task(content, DateTime.Now));
            FileHandler.Add_Task(FileHandler.Tasks_File,Tasks[Tasks.Count-1]);
           
        }
       
        public bool Remove_Task(int TaskNumber)
        {
           
            Tasks.RemoveAt(TaskNumber-1);
            return true;
        }
        public bool UpdateTask(int TaskNumber,string New_Content)
        {
            if (!Check_Valid_Task_Number(TaskNumber))
            {
                return false;
            }
            Tasks[TaskNumber-1].Details = New_Content;
          return true;
        }
        public bool CompeleteTask(int TaskNumber)
        {
            if (!Check_Valid_Task_Number(TaskNumber))
            {
                return false;
            }
            Task task = Tasks[TaskNumber-1];
            task.Time = DateTime.Now;
            Tasks.RemoveAt(--TaskNumber);
            FileHandler.Add_Task(FileHandler.Completed_Tasks_File, task);
            return true;
        }




    }
}
