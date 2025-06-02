using Algorithms;
using System.Security.AccessControl;
using A = System.Console;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LevToBinary(7));
      

        /*DropedList dropedList = new DropedList();
        dropedList.AddWord("saad");
        dropedList.AddWord("rad");
        dropedList.AddWord("2ad");
        dropedList.AddWord("23ad");
        dropedList.DeleteName("saad");

        dropedList.Print();*/
        
        Haider_LinkedList haider_LinkedList = new Haider_LinkedList();
        haider_LinkedList.Add(3);
        haider_LinkedList.Add(33);
        haider_LinkedList.Add(21);
        haider_LinkedList.Add(1);
        haider_LinkedList.Sort();
        haider_LinkedList.RecPrint();


    }
    #region Method
   
    #region amilah

    static int amilah(int a)
    {
        int n = a--;
        for (; a > 1; a--)
            n *= a;
        return n;
    }
    static int Recamilah(int a)
    {
        if (a == 1)
            return 1;
        return a * Recamilah(a - 1);
    }
    #endregion

    #region Power
    static int Power(int n, int power)
    {
        if (power == 0)
            return 1;
        if (power == 1)
            return n;
        return n * Power(n, power-1);
    }
    #endregion

    #region Binary_Search

    static int? Binary_Search(int[] a, int search)
    {
        int start = 0;
        int end = a.Length;
        while (start < end)
        {
            int midpoint = (start + end) / 2;
            if (a[midpoint] == search)
                return midpoint;
            if (a[midpoint] < search)
                start = midpoint + 1;
            else
                end = midpoint;
        }
        return null;
    }
    static int RecBinary_Search(int[] a, int search)
    {
        int start = 0;
        int end = a.Length;
        return ForRecBinary_Search(a, search, start, end);
    }
    static int ForRecBinary_Search(int[] a, int search, int start, int end)
    {
        int midpoint = (start + end) / 2;
        if (a[midpoint] == search)
            return midpoint;

        else if (a[midpoint] < search)
            start = midpoint + 1;

        else
            end = midpoint;

        if (start == end)
            return -1;

        else
            return ForRecBinary_Search(a, search, start, end);
    }

    static int TernySearch(int[] a, int target, int start, int end)
    {
        throw new NotImplementedException();
    }


    #endregion

    #region LinearSearch
    static int LinearSearch<T>(T[] a, T value)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Equals(value))
                return i;
        }
        return -1;
    }

    static int RecLinearSearch<T>(T[] a, T value)
    {
        return ForRecLinearSearch(a, 0, value);
        return -1;
    }
    static string LevToBinary(int num)
    {
        if(num == 1) return num.ToString();

        int div = num / 2;
        int rem = num % 2;

        return LevToBinary(div) + rem;
    }
    static int ForRecLinearSearch<T>(T[] a, int i, T value)
    {
        if (i >= a.Length)
            return -1;
        if (a[i].Equals(value))
            return i;
        return ForRecLinearSearch(a, ++i, value);
    }

    #endregion

    #endregion

    public static string RecBinaryNum(int n)
    {
        string res = string.Empty;
        if (n > 1)
        {
            res += RecBinaryNum(n / 2);
        }
        if (n % 2 == 0)
            return res + "0";
        else
            return res + "1";
    }
    public static void RecTheerdyNum(int n)
    {
        if (n > 1)
        {
            RecBinaryNum(n / 3);
        }
        if (n % 3 == 0)
            Console.Write('0');
        else if (n % 3 == 1)
            Console.Write('1');
        else
            Console.Write('2');
    }

    public static void ConvertTo(int number, int code)
    {
        if (number > 1)
        {
            ConvertTo(number / code, code);
        }
        int sw = number % code;
        for (int i = 0; i < code; i++)
        {
            if (sw == i)
                Console.Write(sw);
        }
    }


}
class MyNodeGG
{
    public int Data { get; set; }
    public MyNodeGG Next { get; set; }
    public MyNodeGG(int data) { Data = data; }

}
class MyLinkedListGG
{
    public MyNodeGG First { get; set; }
    public MyNodeGG Last { get; set; }
    public void AddInOrder(int data)
    {
        if (First == null)
        { Last = First = new MyNodeGG(data); return; }
        if (data <= First.Data)
        {
            MyNodeGG first = new MyNodeGG(data);
            first.Next = First;
            First = first;
            return;
        }
        if (data >= Last.Data)
        {
            MyNodeGG last = new MyNodeGG(data);
            Last.Next = last;
            Last = last;
            return;
        }
        MyNodeGG temp = First.Next;
        MyNodeGG pre = First;
        while (temp != null)

        {
            if (data < temp.Data)
            {
                MyNodeGG first = new MyNodeGG(data);
                first.Next = temp;
                pre.Next = first;
                return;
            }

            pre = temp;
            temp = temp.Next;
        }
    }
    public void PrintAll()
    {
        MyNodeGG Start = First;
        while (Start != null)
        {
            Console.WriteLine(Start.Data);
            Start = Start.Next;
        }
    }

}



public class AVLTree
{
    // Node structure for AVL Tree
    public class Node
    {
        public int Value;
        public Node? Left;
        public Node? Right;
        public int Height;

        public Node(int value)
        {
            Value = value;
            Left = Right = null;
            Height = 1;
        }
    }

    private Node? _root;

    // Function to get the height of the node
    private static int GetHeight(Node? node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }

    // Function to get the balance factor of the node
    private static int GetBalance(Node? node)
    {
        if (node == null)
            return 0;
        return GetHeight(node.Left) - GetHeight(node.Right);
    }

    // Right rotation
    private static Node RightRotate(Node ImBalacnced_node)
    {
        Node LeftChild = ImBalacnced_node.Left;
        Node RightSubTreeOfLeftChild = LeftChild.Right;

        // Perform rotation
        LeftChild.Right = ImBalacnced_node;
        ImBalacnced_node.Left = RightSubTreeOfLeftChild;

        // Update heights
        ImBalacnced_node.Height = Math.Max(GetHeight(ImBalacnced_node.Left), GetHeight(ImBalacnced_node.Right)) + 1;
        LeftChild.Height = Math.Max(GetHeight(LeftChild.Left), GetHeight(LeftChild.Right)) + 1;

        // Return new root
        return LeftChild;
    }

    // Left rotation
    private Node LeftRotate(Node ImBalacnced_node)
    {
        Node RightChild = ImBalacnced_node.Right;
        Node LeftSubTreeOfRightChild = RightChild.Left;

        // Perform rotation
        RightChild.Left = ImBalacnced_node;
        ImBalacnced_node.Right = LeftSubTreeOfRightChild;

        // Update heights
        ImBalacnced_node.Height = Math.Max(GetHeight(ImBalacnced_node.Left), GetHeight(ImBalacnced_node.Right)) + 1;
        RightChild.Height = Math.Max(GetHeight(RightChild.Left), GetHeight(RightChild.Right)) + 1;

        // Return new root
        return RightChild;
    }

    // Insert a value into the AVL tree and balance it
    public void Insert(int value)
    {
        _root = Insert(_root, value);
    }

    private Node Insert(Node node, int value)
    {
        // Step 1: Perform the normal BST insertion
        if (node == null)
            return new Node(value);

        if (value < node.Value)
            node.Left = Insert(node.Left, value);
        else if (value > node.Value)
            node.Right = Insert(node.Right, value);
        else
            return node; // Duplicates are not allowed

        // Step 2: Update the height of the current node
        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

        // Step 3: Get the balance factor of the node to check whether it became unbalanced
        int balance = GetBalance(node);

        // Step 4: If the node is unbalanced, then there are 4 cases

        // Left Left Case
        if (balance > 1 && value < node.Left.Value)
            return RightRotate(node);

        // Right Right Case
        if (balance < -1 && value > node.Right.Value)
            return LeftRotate(node);

        // Left Right Case
        if (balance > 1 && value > node.Left.Value)
        {
            node.Left = LeftRotate(node.Left);
            return RightRotate(node);
        }

        // Right Left Case
        if (balance < -1 && value < node.Right.Value)
        {
            node.Right = RightRotate(node.Right);
            return LeftRotate(node);
        }

        // Return the (unchanged) node pointer
        return node;
    }

    // Inorder traversal (for testing purposes)
    public void InOrderTraversal()
    {
        InOrderTraversal(_root);
    }

    private void InOrderTraversal(Node node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }
}