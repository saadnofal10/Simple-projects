namespace Algorithms;
internal class FlatList
{
    class Node
    {
        public Node? Next { get; set; }
        public Flat Data { get; set; }
        public Node() { }
        public Node(Flat data)
        {
            Data = data;
        }
    }
    Node First;
    Node Last;
    int Length = 0;
    public void AddLast(Flat data)
    {
        Node newnode = new(data);
        if (Length == 0)
        {
            First = newnode;
            Last = newnode;
        }
        else
        {
            Last.Next = newnode;
            Last = newnode;
        }
        Length++;
    }
    public int KnowCountGreaterThenNumber(int number)
    {
        var cr = First;
        int count = 0;
        while (cr != null)
        {
            if (cr.Data.RentPrice > number)
            {
                count++;
            }
            cr = cr.Next;
        }
        return count;
    }

    public void RemoveByAdress(string data)
    {
        if (First.Data.Address == data)
        {
            First = First.Next;
            return;
        }
        var cr = First.Next;
        while (cr.Next != null)
        {
            if (cr.Next.Data.Address == data)
                break;
            cr = cr.Next;
        }
        var post = cr.Next.Next;
        cr.Next = post;
    }

    public void PrintAll()
    {
        var cr = First;
        while (cr != null)
        {
            Console.Write($"-> {cr.Data}");
            cr = cr.Next;
        }
        Console.WriteLine();
    }
}

public class Flat
{
    public string Address { get; set; }
    public int RoomNumber { get; set; }
    public double RentPrice { get; set; }

    public override string ToString() => $"{Address} {RentPrice} {RoomNumber}";
}

