Console.Write ("Введите имя пользователя : ");
string userName = Console.ReadLine();
if(userName.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это Маша!!!");
}
else
{
   Console.Write("Привет, ");
   Console.WriteLine(userName);
}