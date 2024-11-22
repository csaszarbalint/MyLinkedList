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

            var node = EndNode(Head);

            node.next = new Node<T>()
            {
                value = data,
                prev = node,
                next = null
            };
        }

        //idk if this works lol
        public void Insert(int index, T data)
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

            if (index < 0) index = 0;

            var node = WalkNodesToIndex(index, Head);

            var temp = node.next;
            node.next = null;
            Add(data);

            EndNode(Head).next = temp;
        }
        public void Remove(T data)
        {

        }
        public T Get(int index)
        {
            return WalkNodesToIndex(index, Head).value;            
        }

        private Node<T> WalkNodesToIndex(int to, Node<T> from)
        {
            if (to <= 0 || from.next == null) return from;
            return WalkNodesToIndex(to--, from.next);
        }

        private Node<T> EndNode(Node<T> node)
        {
            if (node.next == null) return node;
            return EndNode(node.next);
        }
    }
}
