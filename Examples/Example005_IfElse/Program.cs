Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //ToLower() переводит текст в нижний регистр т.е. пофиг как писать маша-МаШа-и тд.
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}