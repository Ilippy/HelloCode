//Принимаем числа из консоли
//Console.WriteLine("Введите первое целое число");
//string numberA = Console.ReadLine();
//Console.WriteLine("Введите второе целое число");
//string numberB = Console.ReadLine();
//int sum = int.Parse(numberA) + int.Parse(numberB);

// Рандомно назначаем числа от 1 до 9
int numberA = new Random().Next(1, 10); // 1,2,3,4 ... 9
int numberB = new Random().Next(1, 10); // 1,2,3,4 ... 9
int sum = numberA + numberB;
Console.WriteLine($"Сумма чисел {numberA} и {numberB} равняется {sum}!");