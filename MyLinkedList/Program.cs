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

            foreach(int i in Enumerable.Range(1,10)) linkedList.Add(i);
            Console.WriteLine(linkedList);

            linkedList.Insert(5, 99);
            Console.WriteLine(linkedList);

            linkedList.Remove(2);
            Console.WriteLine(linkedList);

            Console.WriteLine(linkedList.Get(10));
        }
    }
}
