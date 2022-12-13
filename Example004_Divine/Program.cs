Console.WriteLine("Введите первое дробное число через запятую");
string numberA = Console.ReadLine();
Console.WriteLine("Введите второе дробное число через запяту");
string numberB = Console.ReadLine();
double sum = double.Parse(numberA) / double.Parse(numberB);
Console.WriteLine($"Деление чисел {numberA} и {numberB} равняется {sum}!");
