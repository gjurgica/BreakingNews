using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Medium
    {
        public delegate void MediumEventHandeler(object sender,EventClass info);
        public event MediumEventHandeler Delegate1;
        public  void SendBreakingNews(string title,string body,DateTime date)
        {
            EventClass info = new EventClass(title, body, date);
            Delegate1?.Invoke(this, info);
        }
        
    }
}
