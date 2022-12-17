internal class Program
{
    private static void Main(string[] args)
    {
        int a1 = 13;
        int b1 = 21;
        int c1 = 39;
        int a2 = 16;
        int b2 = 26;
        int c2 = 69;
        int a3 = 21;
        int b3 = 2;
        int c3 = 15;

        // int max = a1;
        // if (b1 > max) b1 = max;
        // if (c1 > max) c1 = max;
        // if (a2 > max) a2 = max;
        // if (b2 > max) b2 = max;
        // if (c2 > max) c2 = max;
        // if (a3 > max) a3 = max;
        // if (b3 > max) b3 = max;
        // if (c3 > max) c3 = max;


        // int max1 = Max(a1, b1, c1);
        // int max2 = Max(a2, b2, c2);
        // int max3 = Max(a3, b3, c3);
        // int max = Max(max1, max2, max3);

        int max = (Max(a1, b1, c1),
                    Max(a2, b2, c2),
                    Max(a3, b3, c3));



        System.Console.WriteLine(max);
    }

    static int Max(int a, int b, int c)
    {
        int result = a;
        if (b > result) result = b;
        if (c > result) result = c;
        return result;
    }
}