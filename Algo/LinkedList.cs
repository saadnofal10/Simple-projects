namespace Algorithms_LinkedList
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        #region ctor

        public Node() { }
        public Node(T data) => Data = data;
        public Node(Node<T> next) { Next = next; }

        #endregion

    }

    internal class LinkedList1<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }

        #region Ctor

        public LinkedList1() { }
        public LinkedList1(T data)
        {
            Node<T> node = new Node<T>(data);
            First = node;
            Last = node;
        }
        public LinkedList1(Node<T> first)
        {
            First = first;
            Last = first;
        }
        #endregion

        #region AddFirst

        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }

            node.Next = First;
            First = node;
        }
        public void AddFirst(Node<T> node)
        {
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }
            node.Next = First;
            First = node;
        }

        #endregion

        #region AddLast

        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);
            if (Last == null)
            {
                First = node;
                Last = node;
                return;
            }
            Last.Next = node;
            Last = node;
        }
        public void AddLast(Node<T> data)
        {
            if (Last == null)
            {
                First = data;
                Last = data;
                return;
            }
            Node<T> move = Last;
            while (move.Next != null)
                move = move.Next;
            move.Next = data;
            move = Last;
        }

        #endregion

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T>? node = First;
            while (node != null)
            {
                yield return node;
                node = node.Next;
            }
        }

        public void PrintAll()
        {
            foreach (Node<T> node in this)
            {
                Console.WriteLine(node.Data);
            }
        }

    }
}
