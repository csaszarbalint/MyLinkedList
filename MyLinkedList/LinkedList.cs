using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyLinkedList
{
    class Node<T>
    {
        public Node<T> next;
        public Node<T> prev;
        public T value { get; set; }
    }
    class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public LinkedList()
        {
            Head = new Node<T>();
        }

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>()
                {
                    value = data,
                    prev = null,
                    next = null
                };
                return;
            }

            var node = this.Head;
            while(node.next != null)
            {
                node = node.next;
            }

            node.next = new Node<T>()
            {
                value = data,
                prev = node,
                next = null
            };
        }
        public void Insert(int index, T data)
        {
            if (Head == null)
                throw new Exception("No HEAD"); 

            if(!Enumerable.Range(0,this.Length(this.Head)+1).Contains(index)) 
                throw new IndexOutOfRangeException();

            var node = this.Head;
            while(index-- != 0)
            {
                node = node.next;
            }

            var tempNode = node.next;
            node.next = new Node<T>()
            {
                prev = node,
                next = tempNode,
                value = data
            };
        }
        public void Remove(T data)
        {
            if (Head == null)
                throw new Exception("No HEAD"); 

            var node = this.Head;
            while (node.next != null)
            {
                node = node.next;
                if(node.value.Equals(data))
                {
                    //remove node 
                    node.prev.next = node.next;
                    return;
                }
            }
            Console.WriteLine("Value not found!");
        }
        public T Get(int index)
        {
            if (Head == null)
                throw new Exception("No HEAD"); 

            if(!Enumerable.Range(0,this.Length(this.Head)).Contains(index)) 
                throw new IndexOutOfRangeException();

            var node = this.Head.next;
            while(index-- != 0)
            {
                node = node.next;
            }
            return node.value;
        }
        public int Length (Node<T> node, int depth = 0) 
        {
            if (node.next == null) { return depth; }
            return Length(node.next, ++depth);  
        }

        public override string ToString()
        {
            string spacer = " -> ";
            string ret = "HEAD";

            var node = this.Head;
            while(node.next != null)
            {
                node = node.next;
                ret += spacer + node.value ;
            }
            return ret; 
        }
    }
}
