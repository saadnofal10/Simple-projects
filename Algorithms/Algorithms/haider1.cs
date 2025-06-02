namespace Algorithms;


internal class Haider_LinkedList
{
    public class Node(int data)
    {
        public int Data { get; set; } = data;
        public Node Next { get; set; }
    }

    private Node First { get; set; }
    private int count = 0;

    public void Add(Node node)
    {
        node.Next = First;
        First = node;
        count++;
    }
    public void Add(int data)
    {
        var node = new Node(data);
        node.Next = First;
        First = node;
        count++;
    }


    public void Sort()
    {
        if (count == 0)
        {
            Console.WriteLine("Saad is gay and has 👌 one");
            return;
        }

        bool isSwap = false;
        for (int i = 1; i < count; i++)
        {
            Node f = First;
            Node n = f.Next;
            for (int j = 0; j < count - i; j++)
            {
                if (f.Data > n.Data)
                {
                    (f.Data, n.Data) = (n.Data, f.Data);
                    isSwap = true;
                }
                f = n;
                n = n.Next;
            }
            if (!isSwap)
            {
                continue;
            }
        }
    }

    public void Print()
    {
        var s = First;
        while (s != null)
        {
            Console.Write($"-> {s.Data}");
            s = s.Next;
        }
        Console.WriteLine();
    }
    public void RecPrint()
    {
        ForRecPrint(First);
        Console.WriteLine();
    }
    private void ForRecPrint(Node node)
    {
        if (First == null)
        {
            Console.WriteLine("Zaidon is 3mak");
            return;
        }
        if (node.Next != null)
            ForRecPrint(node.Next);
        Console.Write($"-> {node.Data}");
    }
}
