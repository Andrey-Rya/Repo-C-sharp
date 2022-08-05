// Приветствуем Машу по особенному
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); // считываем данные с консоли в username

if(username.ToLower() == "маша") // ToLover переводит все буквы ввода в нижн регистр
{
    Console.WriteLine("Ура, это же МАША!"); // приветствуем только Машу  
}
else
{
    Console.Write("Привет, "); // приветствуем всех остальных
    Console.WriteLine(username); // приветствуем остальных (2 способ)  
}

