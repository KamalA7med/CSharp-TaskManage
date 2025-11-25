using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class FileHandler
    {
        static private string _Tasks_File = @"..\..\Files\Tasks.txt";
         static private string _Completed_Tasks_File = @"..\..\Files\Completed_Tasks.txt";
       static  public string Tasks_File {  get { return _Tasks_File; } }
         static public string Completed_Tasks_File { get { return _Completed_Tasks_File; } }
       public  static List<Task> Get_Tasks_From_File( string filename )
        {
            List<Task> Tasks=new List<Task> ();
            string[] Lines = File.ReadAllLines(filename);
           
            foreach (var line in Lines)
            {
                string[] content = line.Split('#');
                Tasks.Add(new Task(content[0], DateTime.Parse(content[1])));
            }
            return Tasks;   
        }
        public static  void Save_Changes( List<Task>list)
        {
           string[]Lines=new string[list.Count];
            int i = 0;
            foreach (var task in list)
            {
                string line = task.ToString();
                Lines[i++] = line;
            }
            File.WriteAllLines(_Tasks_File, Lines);
        }
        static public void Add_Task( string file_path,Task task )
        {
            string line = task.ToString();
            StreamWriter  sr=new StreamWriter(file_path,true);
            sr.WriteLine(line);
            sr.Close();

        }
        
    }
}
