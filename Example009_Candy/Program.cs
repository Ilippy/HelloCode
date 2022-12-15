using System;

namespace Example009_Candy
{
    public class Candy
    {
        static void Main(string[] args)
        {
            int candyAmount = EnterNumber("Введите общее количество конфет");
            int maxAmountOfCandyPerTurn = EnterNumber("Введите количество конфет, которое игрок может взять за 1 ход");
            bool isPlayer = true;
            string stringCandyInThisTurn;
            int candyInThisTurn = 0;

            while (candyAmount > 0)
            {
                if (isPlayer)
                {
                    System.Console.WriteLine($"Осталось {candyAmount} конфет(ы)");
                    System.Console.WriteLine($"Введите число конфет, которые вы хотите взять в этом ходу от 1 до {maxAmountOfCandyPerTurn}");
                    stringCandyInThisTurn = Console.ReadLine().Trim();
                    candyInThisTurn = 0;

                    while (!int.TryParse(stringCandyInThisTurn, out candyInThisTurn) || candyInThisTurn <= 0 || candyInThisTurn > maxAmountOfCandyPerTurn)
                    {
                        System.Console.WriteLine($"Ошибка! Введите одно целое число от 1 до {maxAmountOfCandyPerTurn}");
                        stringCandyInThisTurn = Console.ReadLine().Trim();
                    }

                    candyAmount -= candyInThisTurn;
                    isPlayer = false;
                }
                else
                {
                    System.Console.WriteLine($"Осталось {candyAmount} конфет(ы)");
                    candyInThisTurn = candyAmount % (maxAmountOfCandyPerTurn + 1);
                    if (candyInThisTurn == 0)
                    {
                        candyInThisTurn = new Random().Next(1, maxAmountOfCandyPerTurn + 1);
                    }
                    candyAmount -= candyInThisTurn;
                    System.Console.WriteLine($"Компьютер взял {candyInThisTurn} конфет(ы)");
                    isPlayer = true;
                }
                if (candyAmount == 0)
                {
                    if (isPlayer)
                    {
                        System.Console.WriteLine("Победил КОМПЬЮТЕР! Ну как всегда =)");
                    }
                    else
                    {
                        System.Console.WriteLine("Победил игрок. Ну наконец-то =D");
                    }
                }
            }

        }

        static int EnterNumber(string str)
        {
            System.Console.WriteLine(str);
            string stringNumber = Console.ReadLine().Trim();
            int number;
            while (!int.TryParse(stringNumber, out number) || number <= 0)
            {
                Console.WriteLine("Ошибка! Введите одно целое число");
                stringNumber = Console.ReadLine().Trim();
            }
            return number;
        }

        // static int enterInt(string str);
        // System.Console.WriteLine(str);
        // int number;
        // {
        //     while(!int.TryParse(str, out number))
        //     {
        //         System.Console.WriteLine("Ошибка! Введите одно целое число");
        //         str = Console.ReadLine().Trim();
        //     }
        //     return number;
        // }

    }
}





