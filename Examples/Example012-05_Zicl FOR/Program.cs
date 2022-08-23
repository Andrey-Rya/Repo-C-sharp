// различное использование цикла FOR (повтор текста 10 раз подряд)

// string Method4(int count, string text) // возвращаем строку с и друг за другом разместим count раз
// {
//     string result = String.Empty; // изначально это пустая строка String.Empty
//     for (int i = 0; i < count; i++) // (инициализация счетчика; проверка условия; увеличение счетчика)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "текст 10 раз, ");// вызываем метод и склеиваем текст 10 раз 
// Console.WriteLine(res);

// **Использование цикла внутри цикла**//

/*пример вывода таблицы умножения в консоль*/
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); // перемножение чисел
    }
    Console.WriteLine(); // разрыв строки
}
