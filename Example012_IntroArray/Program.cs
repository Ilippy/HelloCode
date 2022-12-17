internal class Program
{
    private static void Main(string[] args)
    {
        //              0  1  2  3  4  5  6  7  8
        int[] array = {32,12,63,43,52,46,97,58,19};
        int max = 0;
        foreach (int number in array)
            if( number > max) max = number;
        

        // max = Max(Max(array[0], array[1], array[2]),
        //             Max(array[3], array[4], array[5]),
        //             Max(array[6], array[7], array[8]));



        System.Console.WriteLine(max);
    }

    // static int Max(int a, int b, int c)
    // {
    //     int result = a;
    //     if (b > result) result = b;
    //     if (c > result) result = c;
    //     return result;
    // }
}