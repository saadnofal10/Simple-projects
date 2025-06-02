namespace Algorithms
{
    partial class Node
    {
        public int Data { get; set; }
        public int Id { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node() { }
        public Node(int data) => this.Data = data;

    }
    internal class Tree
    {
        Node root;
        int index = 0;
        public Tree() { }
        public Tree(Node root) => this.root = root;
        #region first_Try_ToADD
        //public void Add(int data)
        //{
        //    if (root == null)
        //        root = new Node(data);
        //    else
        //    {
        //        Node move = root;
        //        while (move.Right != null && move.Left != null)
        //        {
        //            if (root.Data > data)
        //                move = move.Left;
        //            else
        //                move = move.Right;
        //        }
        //        if (root.Data > data)
        //            move.Left = new Node(data);
        //        else
        //            move.Right = new Node(data);
        //    }
        //}
        #endregion
        public void Add(int data)
        {
            if (root == null)
            {
                root = new Node(data);
                root.Id = index++;
            }
            else
            {
                Node move = root;
                while (true)
                {
                    if (move.Data > data)
                    {
                        if (move.Left == null)
                        {
                            move.Left = new Node(data);
                            move.Left.Id = index++;
                            return;
                        }
                        move = move.Left;
                    }
                    else
                    {
                        if (move.Right == null)
                        {
                            move.Right = new Node(data);
                            move.Right.Id = index++;
                            return;
                        }
                        move = move.Right;
                    }
                }
            }
        }
        public Node InsertByRoot(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
                node.Id = index++;
                return node;
            }
            if (node.Data > data)
                node.Left = InsertByRoot(node.Left, data);
            else
                node.Right = InsertByRoot(node.Right, data);
            return node;
        }
        public void Insert(int data)
        {
            root = InsertByRoot(root, data);
        }

        public int BinerySearchByData(int data)
        {
            Node move = root;
            while (move != null)
            {
                if (move.Data == data)
                    return move.Id;
                else if (move.Data > data)
                    move = move.Left;
                else
                    move = move.Right;
            }
            return -1;
        }
        public int BinerySearchById(int data)//Error
        {
            Node move = root;
            while (move != null)
            {
                if (move.Data == data)
                    return move.Id;
                else if (move.Data > data)
                    move = move.Left;
                else
                    move = move.Right;
            }
            return -1;
        }
        private void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.WriteLine(root.Data);
                InOrderTraversal(root.Right);
            }
        }
        public void PrintInOrderTraversal()//L,R,N
        {
            InOrderTraversal(root);
        }
        private void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data);
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }
        public void PrintPreOrderTraversal()//N,L,R
        {
            PreOrderTraversal(root);
        }
        private void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.WriteLine(root.Data);
            }
        }
        public void PrintPostOrderTraversal()// L,R,N
        {
            PostOrderTraversal(root);
        }

    }
}
