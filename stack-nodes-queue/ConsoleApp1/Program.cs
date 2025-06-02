using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            stack stacks = new stack();
            stacks.puch(100);
            stacks.puch(20);
            stacks.peek();

            Console.WriteLine(stacks);

            Q q = new Q();
            q.push(7);
            q.push(2);
            q.push(3);
            q.push(4);
            q.push(5);
            q.push(6);

            Console.WriteLine(q.peek());

        }
    }
}
class node
{
    int data;
    public int Data { get { return data; } set { data = value; } }
    node next;
    public node Next { get { return next; } set { next = value; } }
    public node(int data) { this.data = data; }
    public node() { }
}
class stack
{
    node top;  // imp
    public stack() { }
    public stack(int data)
    {
        top = new node();
        top.Data = data;

    }
    public void puch(int data) // للاضافة
    {

        node d = new node(data);//انشاء عقدة فيها بيانات 

        d.Next = top;//انشاء توب جديد
        top = d;//جعل القمة تكسب بيانات

    }

    public string peek() // بتعطيك اخر قيمة من دون حذف
    {
        if (top == null) // شوفو اذا فاضي طبعلي انو فاضي
        {
            return "Empty";
        }
        return top.Data.ToString();// طبعلي الببيانات تبع التوب
    }
    public string pop()//حذف  التوب
    {
        if (top == null)
        {
            return "empty";
        }
        top = top.Next;// معس او حذفففف
        return top.Data.ToString();
    }

    public static stack operator +(stack a, int b)
    {

        stack n = new stack(b);
        n.top.Next = a.top;
        return n;
    }

    public static stack operator --(stack a)
    {
        a.pop();
        return a;
    }
    public override string ToString()
    {
        return peek();
    }
}
/// <summary>
/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
class Q
{
    node first;
    public Q() { }
    public Q(int data) { first = new node(data); }
    public void push(int data)
    {
        if (first == null)
        {
            first = new node(data);
        }
        else
        {
            node d = new node(data);
            node move = first;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = d;

        }
    }
    public string peek()
    {
        if (first == null)
        {
            return "empty";
        }

        return first.Data.ToString();
    }
    public string pop() // del
    {

        if (first == null)
        {
            return "empty";
        }
        first = first.Next; // m3s delete
        return first.Data.ToString();
    }
    public void print()
    {
        node move = first;
        while (move != null)
        {
            Console.WriteLine(move.Data);
            move = move.Next;
        }
    }
    public override string ToString()
    {
        return first.Data.ToString();
    }
}
