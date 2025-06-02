using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Masfofa
    {
        class Node
        {
            public Node? Next { get; set; }
            public int Data { get; set; }
            public Node()
            {
                Next = null;
            }
            public Node(int data)
            {
                Data = data;
                Next = null;
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
                First = newnode;
                Last = newnode;
            }
            else
            {
                newnode.Next = First;
                First = newnode;
            }
            Length++;
        }
        public void BubbleSort()
        {
            if (Length == 0)
            {
                Console.WriteLine("There is no list to sort.");
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                Node? currentNode = First;

                while (currentNode != null && currentNode.Next != null)
                {
                    if (currentNode.Data > currentNode.Next.Data)
                    {
                        int temp = currentNode.Data;
                        currentNode.Data = currentNode.Next.Data;
                        currentNode.Next.Data = temp;
                        swapped = true;
                    }
                    currentNode = currentNode.Next;
                }
            } while (swapped);
        }
        public void print()
        {
            Node curr = First;
            while (curr != null)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Next;
            }
        }
        public void PrintRec()
        {
            if (Length == 0)
            {
                Console.WriteLine("No list");
                return;
            }
            if (Length > 0)
            {

                Print(First);

            }
        }
        private void Print(Node t)
        {
            if(t.Next != null)
            {
                Print(t.Next);
            }
            Console.WriteLine(t.Data);
        }
    }
}

