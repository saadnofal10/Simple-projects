using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList LS = new LinkedList();
            LS.InsertFirst(2);
            LS.InsertFirst(21);
            LS.InsertFirst(23);
            LS.insertPos(4,12);
            LS.print();
        }
    }
}
class LinkedList
{
    class Node
    {
        public Node next { set; get; }
        public int data { set; get; }
        public Node()
        {
            next = null;
        }
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    Node First;
    Node Last;
    int Length;
    public LinkedList()
    {
        Length = 0;
        First = null;
        Last = null;
    }
    public bool IsEmpty()
    {
        return Length == 0;
    }
    
    public void InsertFirst(int data)
    {
        Node newnode = new Node();
        newnode.data = data;
        if (IsEmpty())
        {
            First = Last = newnode;
            newnode.next = null;
        }
        else
        {
            newnode.next = First;
            First = newnode;
        }
        Length++;
    }
    public void InsertLast(int data)
    {
        Node newnode = new Node();
        newnode.data = data;
        if (IsEmpty()) {
            InsertFirst(data);
        }
        else
        {
            Last.next = newnode;
            newnode.next = null;
            Last = newnode;
            Length++;    
        }
    }
    public void insertPos(int pos , int data) 
    {
        if (pos < 0 || pos > Length)
        {
            Console.WriteLine("Out of range");
        }
        else
        {
            Node node = new Node();
            node.data = data;
            if (pos == 0)
            {
                InsertFirst(data);
            }
            else if (pos == Length)
            {
                InsertLast(data);
            }
            else
            {
                Node Cur = First;
                for(int i = 1; i < pos; i++)
                {
                    Cur = Cur.next;
                }
                node.next = Cur.next;
                Cur.next = node;
                Length++;   
            }
        }
    }
    public void print()
    {
        Node Cur = First;
        while (Cur!=null)
        {
            Console.WriteLine(Cur.data);
            Cur=Cur.next;
        }
    }
   
}
