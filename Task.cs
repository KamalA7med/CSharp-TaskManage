using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Task
    {
        
        public string Details;
        public DateTime Time;
        public Task(string details, DateTime time)
        {
            Details = details;
            this.Time = time;

        }
        public string ToString()
        {
            
            return Details + "#" + Time.ToString();
        }
        
    }
}
