Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Яночка")
{
    Console.WriteLine("Ура это же ЯНОЧКА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}