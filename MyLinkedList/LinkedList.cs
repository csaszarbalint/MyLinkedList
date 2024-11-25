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
        }
        public void Remove(T data)
        {

        }
        public T Get(int index)
        {
            return (T) new object();
        }
    }
}
