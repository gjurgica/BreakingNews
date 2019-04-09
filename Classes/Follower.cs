using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Follower 
    {
        public string Name { get; set; }
        public Follower(string name)
        {
            Name = name;
        }
        public void Subscribe(Medium med)
        {
            med.Delegate1 += new Medium.MediumEventHandeler(PrintNews);
        }
        public void PrintNews(object obj,EventClass info)
        {
            Console.WriteLine($"The latest News: \n{info.Title}\n{info.Body}\n{info.Date}");
        }
    }
}
