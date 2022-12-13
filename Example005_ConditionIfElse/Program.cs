Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "илья")
{
    Console.WriteLine("Ура! Это же ИЛЬЯ!");
} 
else 
{
    Console.WriteLine($"Привет, {username}");
}