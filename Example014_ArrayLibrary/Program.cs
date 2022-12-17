using System;

class Program
{
    private static void Main(string[] args)
    {
        //создать массив из 10 элементов из 0 и записать в переменную array
        int[] array = new int[10];
        FillArray(array);
        PrintArray(array);
        // System.Console.WriteLine();
        // PrintArrayForEach(array);
        System.Console.WriteLine();
        int random = FindRandomNumber(array);

        int pos = IndexOf(array, random);
        System.Console.WriteLine($"pos = {pos}");



    }

    static void FillArray(int[] collection)
    {
        int lenth = collection.Length;

        Random random = new Random();
        for (int i = 0; i < lenth; i++)
        {
            collection[i] = random.Next(1, 10);
            i++;
        }
        // TODO: понять почему этот код выводит "0 3 3 3 3 3 3 3 3 3", "0 7 7 7 7 7 7 7 7 7", "0 6 6 6 6 6 6 6 6 6"
        // foreach (int index in collection) collection[index] = new Random().Next(1, 10);

    }

    static void PrintArray(int[] col)
    {
        for (int i = 0; i < col.Length; i++)
        {
            System.Console.Write($"{col[i]} ");
        }
    }

    static void PrintArrayForEach(int[] col)
    {
        foreach (int i in col)
        {
            System.Console.Write($"{i} ");
        }
    }



    static int FindRandomNumber(int[] col)
    {
        int length = col.Length;
        int random = new Random().Next(0, length);
        System.Console.WriteLine($"random number of array is {col[random]}");
        return col[random];
    }

    static int IndexOf(int[] col, int find)
    {
        for(int i = 0; i < col.Length; i++)
        {
            if (col[i] == find)
            {   
                return i;
            }
        }
        return 80085;
    }
}