System.Console.WriteLine("Введите общее количество конфет");
string stringCandyAmount = Console.ReadLine().Trim();
int candyAmount;
while(!int.TryParse(stringCandyAmount, out candyAmount))
{
    System.Console.WriteLine("Ошибка! Введите одно целое число");
    stringCandyAmount = Console.ReadLine().Trim();
}
// candyAmount = enterInt(stringCandyAmount);

// System.Console.WriteLine(candyAmount);

System.Console.WriteLine("Введите количество конфет, которое игрок может взять за 1 ход");
string stringMaxAmountOfCandyPerTurn = Console.ReadLine().Trim();
int maxAmountOfCandyPerTurn;
while(!int.TryParse(stringMaxAmountOfCandyPerTurn, out maxAmountOfCandyPerTurn))
{
    System.Console.WriteLine("Ошибка! Введите одно целое число");
    stringMaxAmountOfCandyPerTurn = Console.ReadLine().Trim();
}
// amountOfCandyPerTurn = enterInt(stringAmountOfCandyPerTurn);
// System.Console.WriteLine(amountOfCandyPerTurn);

bool isPlayer = true;
string stringCandyInThisTurn;
int candyInThisTurn = 0;

while(candyAmount > 0)
{
    if(isPlayer)
    {
        System.Console.WriteLine($"Осталось {candyAmount} конфет(ы)");
        System.Console.WriteLine($"Введите число конфет, которые вы хотите взять в этом ходу от 1 до {maxAmountOfCandyPerTurn}");
        stringCandyInThisTurn = Console.ReadLine().Trim();
        candyInThisTurn = 0;
       
            while(!int.TryParse(stringCandyInThisTurn, out candyInThisTurn) || candyInThisTurn <= 0 || candyInThisTurn > maxAmountOfCandyPerTurn)
            {
                System.Console.WriteLine($"Ошибка! Введите одно целое число от 1 до {maxAmountOfCandyPerTurn}");
                stringCandyInThisTurn = Console.ReadLine().Trim();
            }
        
        candyAmount -= candyInThisTurn;
        isPlayer = false;
    } else 
    {
        System.Console.WriteLine($"Осталось {candyAmount} конфет(ы)");
        candyInThisTurn = candyAmount % (maxAmountOfCandyPerTurn + 1);
        if (candyInThisTurn == 0)
        {
            candyInThisTurn = new Random().Next(1,maxAmountOfCandyPerTurn + 1);
        }
        candyAmount -= candyInThisTurn;
        System.Console.WriteLine($"Компьютер взял {candyInThisTurn} конфет(ы)");
        isPlayer = true;
    }
    if(candyAmount == 0)
    {
        if(isPlayer)
        {
            System.Console.WriteLine("Победил КОМПЬЮТЕР! Ну как всегда =)");
        } else {
            System.Console.WriteLine("Победил игрок. Ну наконец-то =D");
        }
    }
}




// int enterInt(string str);
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