class Rec
{
    int[] a;
    public Rec(int Length)
    {
        a = new int[Length];
    }
    public void fill()
    {
        Random random = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 100);
        }
    }
    public void SelectionSortRec()
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            int min = FindMin(i + 1, i);
            int t = a[i];
            a[i] = a[min];
            a[min] = t;
        }

    }
    public int FindMin(int j, int min)
    {
        if (j >= a.Length)
        {
            return min;
        }
        if (a[j] < a[min])
        {
            min = j;
        }
        return FindMin(j + 1, min);

    }
    public void Print()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i] + " ");
        }

    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    public class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        // لإضافة عقدة في البداية  
        public void AddToFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        // لإضافة عقدة في النهاية  
        public void AddToEnd(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }

            AddToEndRecursive(head, data);
        }

        private void AddToEndRecursive(Node<T> node, T data)
        {
            if (node.Next == null)
            {
                node.Next = new Node<T>(data);
            }
            else
            {
                AddToEndRecursive(node.Next, data);
            }
        }

        // لإضافة عقدة في موقع محدد  
        public void AddAtPosition(int position, T data)
        {
            if (position < 0)
            {
                throw new ArgumentException("الموقع يجب أن يكون أكبر من أو يساوي 0");
            }

            if (position == 0)
            {
                AddToFront(data);
                return;
            }

            AddAtPositionRecursive(head, position, data, 0);
        }

        private void AddAtPositionRecursive(Node<T> node, int position, T data, int currentPosition)
        {
            if (node == null)
            {
                throw new ArgumentOutOfRangeException("الموقع خارج النطاق");
            }

            if (currentPosition == position - 1)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = node.Next;
                node.Next = newNode;
            }
            else
            {
                AddAtPositionRecursive(node.Next, position, data, currentPosition + 1);
            }
        }

        public void PrintList()
        {
            PrintListRecursive(head);
            Console.WriteLine(); // لطباعة سطر جديد بعد الطباعة  
        }

        private void PrintListRecursive(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Data + " -> ");
            PrintListRecursive(node.Next);
        }
    }
}