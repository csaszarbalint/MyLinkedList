using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();

            foreach(int i in Enumerable.Range(1,100)) linkedList.Add(i);
        }
    }
}
