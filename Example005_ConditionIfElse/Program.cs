Console.Write("Представьтесь пожалуйста> ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Урра!!! Это же Маша!");
}
else
{
    Console.WriteLine("Привет " + username);
}

