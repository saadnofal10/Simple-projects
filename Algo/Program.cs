class Program
{
    static void Main(string[] args)
    {
        #region Add_Two_Number
        /*
        int[] a = { 9, 9, 9, 9, 9, 9, 9 };
        int[] b = { 9, 9, 9, 9 };

        int forA = 0, forB = 0, result = 0;
        int power = 1;
        for (int i = 0; i < a.Length; i++)
        {
            forA += a[i] * power;
            power *= 10;
        }
        for (int i = 0; i < a.Length / 2; i++)
        {
            int temp = a[i];
            a[i] = a[a.Length - 1 - i];
            a[a.Length - 1 - i] = temp;
        }
        power = 1;
        for (int i = 0; i < b.Length; i++)
        {
            forB += b[i] * power;
            power *= 10;
        }
        for (int i = 0; i < b.Length / 2; i++)
        {
            int temp = b[i];
            b[i] = b[b.Length - 1 - i];
            b[b.Length - 1 - i] = temp;
        }
        result = forA + forB;
        int _temp = 0;
        int mtemp = 0;
        int Lenght = result.ToString().Length - 1;
        int[] newResult = new int[result.ToString().Length];
        for (int i = 0; i < newResult.Length; i++)
        {
            power = 1;
            for (int j = 0; j < newResult.Length - 1 - i; j++)
                power *= 10;
            _temp = result / power;
            newResult[i] = _temp - mtemp;
            mtemp = _temp * 10;
        }
        Console.WriteLine(result);
        foreach (int i in newResult)
            Console.Write(i);
        */
        #endregion

        #region The_Dreiction
        int n = 3;
        string[] commands = { "DOWN", "RIGHT", "UP" };
        int count = 0;
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                array[i, j] = count++;
        }
        int x = 0, y = 0;
        for (int i = 0; i < commands.Length; i++)
        {
            switch (commands[i])
            {
                case "RIGHT":
                    y++;
                    break;
                case "DOWN":
                    x++;
                    break;
                case "UP":
                    x--;
                    break;
                case "LEFT":
                    y--;
                    break;
            }
        }
        int OutPut = array[x, y];
        Console.WriteLine(OutPut);
        Console.WriteLine();
        #endregion

        Point p1 = new Point(1,7,4);
        Point p2 = new Point(5,3,9);

        Point p3 = new Point(3,3,5);

        Console.WriteLine(p3.contaiins(p1,p2));
    }
}

class Point
{
    int x;
    int y, z;
    public Point() { }
    public Point(int x) => this.x = x;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public bool contaiins(Point p1, Point p2)
    {
        if (!contaiinsX(p1.x, p2.x, x))
            return false;
        //if (p1.y != null && p2.y != null)
            if (!contaiinsX(p1.y, p2.y, y))
                return false;
        //if (p1.z != null && p2.z != null)
            if (!contaiinsX(p1.z, p2.z, z))
                return false;
        return true;
    }
    private bool contaiinsX(int x1, int x2, int x)//cheak for x1,x2 y1,y2 z1,z2
    {
        if (x1 > x2)
        {
            int temp = x1;
            x1 = x2;
            x2 = temp;
        }
        if (x1 > x)
            return false;
        if (x > x2)
            return false;
        return true;
    }
}