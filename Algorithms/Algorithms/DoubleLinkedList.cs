using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class DoubleLinkedList
    {
        class Node
        {
            public int Data { get; set; }
            public Node? Next { get; set; }
            public Node? Prev { get; set; }
            public Node() { }
            public Node(int Data)
            {
                this.Data = Data;
                Next = null;
                Prev = null;
            }
        }

        Node? First;
        Node? Last;
        int Length = 0;
        public void AddFirst(int data)
        {
            Node newnode = new(data);
            if (Length == 0)
            {
                First = Last = newnode;
                //ctor
                //newnode.Next = newnode.Prev = null;
            }
            else
            {
                newnode.Next = First;
                //ctor
                //newnode.Prev= null;
                First.Prev = newnode;
                First = newnode;
            }
            Length++;
        }
        public void AddLast(int data)
        {
            Node newnode = new(data);
            if (Length == 0)
            {
                AddFirst(data);
            }
            else
            {
                newnode.Prev = Last;
                //newnode.Next = null;
                Last.Next = newnode;
                Last = newnode;
                Length++;
            }
        }
        public void AddLastOreder(int data)
        {

            if (Length == 0)
            {
                AddFirst(data);
            }
            else
            {

                Node newnode = new(data);
               

               
                if (newnode.Data >= Last.Data)
                {
                    Last.Next = newnode;
                    newnode.Prev = Last;
                    Last = newnode;

                }
                else if (newnode.Data<=First.Data)
                {
                    First.Prev = newnode;
                    newnode.Next = First;
                    First = newnode;
                }
                else
                {
                    Node cur = First.Next;
                    while (cur!=null && newnode.Data>=cur.Data)
                    {
                        cur = cur.Next;
                    }
                    cur.Prev.Next = newnode;
                    newnode.Prev = cur.Prev;

                    cur.Prev = newnode;
                    newnode.Next = cur;

                }
                Length++;

            }
        }
        public void AddAt(int pos, int data)
        {
            if (pos > Length || pos < 0) { Console.WriteLine("Out Of Rang (OOR Exeption)"); }
            else
            {
                if (pos == 0) AddFirst(data);
                else if (pos == Length) AddLast(data);
                else
                {
                    Node newnode = new(data);
                    Node? Curr = First;
                    for (int i = 0; i < pos; i++)
                    {
                        Curr = Curr.Next;
                    }
                    newnode.Next = Curr.Next;
                    newnode.Prev = Curr;
                    Curr.Next = newnode;
                    Curr.Next.Prev = newnode;
                    Length++;
                }
            }

        }
        public void RemoveFirst()
        {
            if (Length == 0) { Console.WriteLine("There is no node"); }
            else if (Length == 1)
            {
                Last = First = null;
            }
            else
            {
                First = First.Next;
                First.Prev = null;
            }
            Length--;
        }
        public void RemoveLast()
        {
            if (Length == 0) { Console.WriteLine("There is no node"); }
            else if (Length == 1)
            {
                RemoveFirst();
            }
            else
            {
                Last = Last.Prev;
                Last.Next = null;
                Length--;
            }
        }
        public void RemoveByData(int data)
        {
            if (Length == 0) { Console.WriteLine("There is no node"); return; }
            if (First.Data == data) { RemoveFirst(); }
            else
            {
                Node curr = First.Next;
                while (curr != null)
                {
                    if (curr.Data == data) break;
                    curr = curr.Next;
                }
                if (curr == null) { Console.WriteLine("There is no node"); }
                else if (curr.Next == null) { RemoveLast(); }
                else
                {
                    curr.Prev.Next = curr.Next;
                    curr.Next.Prev = curr.Prev;
                    Length--;
                }

            }
        }
        public void Display()
        {
            Node curr = First;
            Console.WriteLine("The Data of the list :");
            while (curr != null)
            {
                Console.Write("<--" + curr.Data + "--> ");
                curr = curr.Next;
            }

        }
        public void Displays()
        {
            Node curr = Last;
            Console.WriteLine("The Data of the list :");
            while (curr != null)
            {
                Console.Write("<--" + curr.Data + "--> ");
                curr = curr.Prev;
            }
        }
    }
}
