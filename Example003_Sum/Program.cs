Console.WriteLine("Введите первое целое число");
string numberA = Console.ReadLine();
Console.WriteLine("Введите второе целое число");
string numberB = Console.ReadLine();
int sum = int.Parse(numberA) + int.Parse(numberB);
Console.WriteLine($"Сумма чисел {numberA} и {numberB} равняется {sum}!");