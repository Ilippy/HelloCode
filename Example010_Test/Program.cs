// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");
string stringNumber = Console.ReadLine();
int number;
while (!int.TryParse(stringNumber, out number))
{
    Console.WriteLine("Ошибка! Введите одно целое число");
    stringNumber = Console.ReadLine().Trim();
}

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());  //int.Parse()
int result = number * number; 

Console.WriteLine($"Квадрат числа {number} будет {result}");  
// Console.WriteLine("Квадрат числа " + {number} + " будет "+ result);