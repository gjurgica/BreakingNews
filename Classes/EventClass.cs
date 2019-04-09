using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EventClass 
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public EventClass(string title,string body,DateTime date)
        {
            Title = title;
            Body = body;
            Date = date;
        }
    }

}
