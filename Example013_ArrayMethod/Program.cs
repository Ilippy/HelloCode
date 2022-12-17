internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 32, 12, 63, 43, 52, 46, 97, 58, 19 };

        int n = array.Length;
        int find = array[new Random().Next(0,array.Length)];
        System.Console.WriteLine(find);

        int index = 0;

        while(index < n)
        {
            if(array[index] == find){
                System.Console.WriteLine(index);
                break;
            }
            index++;
        }
    }
}