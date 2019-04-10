using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> newType = new MyGeneric<int>();
            newType.Add(89);
            newType.Remove(7);
            
        }
    }
    public class MyGeneric<T> where T : IComparable<T>, IConvertible
    {
        private T[] Colect { get; set; }
        public int Count { get; set; }

        

        public void  Add(T elem)
        {
            Colect = new T[Colect.Length+1];
            Colect[Colect.Length-1] = elem;

        }
        public T Remove(T index)
        {
            if (Colect.Length != 0)
            {
                Colect = Colect.Where(num => num.CompareTo(index) == 0).ToArray();
            }
            

        }
        public T this[int index]
        {
            get
            {
                return Array.IndexOf(Colect,index);
            }
        }


    }
}
