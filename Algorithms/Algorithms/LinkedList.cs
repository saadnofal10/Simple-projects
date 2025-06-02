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
            AddFirst(node);
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
            AddLast(node);
        }
        public void AddLast(Node<T> node)
        {
            if (Last == null)
            {
                First = node;
                Last = node;
                return;
            }
            //Node<T> move = Last;
            //while (move.Next != null)
            //    move = move.Next;
            //move.Next = node;
            //Last = node;
            Last.Next = node;
            Last = node;
        }


        #endregion

        #region AddAt

        public void AddAt(T data, int at) => AddAt(new Node<T>(data), at);
        public void AddAt(Node<T> node, int at)
        {
            if (First == null) { First = node; return; }
            Node<T> move = First;
            if (at <= 0) { AddFirst(node); return; }
            at--;
            for (int i = 0; i < at; i++)
            {
                if (move.Next != null)
                    move = move.Next;
            }
            node.Next = move.Next;
            move.Next = node;
        }

        #endregion

        public void RemoveFirst()
        {
            if (First != null)
                First = First.Next;
            if (First == null)
                Last = null;
        }
        public void RemoveLast()
        {
            if (First == null) return;
            if (First.Next == null) { RemoveFirst(); return; }

            Node<T> move = First;
            while (move.Next.Next != null)
                move = move.Next;
            move.Next = null;

        }
        public void RemoveAt(int index)
        {
            if (index < 0) return;
            if (First == null) return;
            Node<T> move = First;

        }

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
            Console.Write("[ ");
            foreach (Node<T> node in this)
            {
                Console.Write(node.Data);
                if (node.Next != null)
                    Console.Write(" - ");
            }
            Console.WriteLine(" ]");
        }




    }
}
