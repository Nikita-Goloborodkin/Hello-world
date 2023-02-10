Console.Write("Введите своё имя:");
string username = Console.ReadLine();
if (username.ToLower() == "George")
{
    Console.Write("Yeah, it is George");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
