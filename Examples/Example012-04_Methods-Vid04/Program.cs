// Метод-04 (int группа) Что-то принимают и что-то возвращают
string Method4(int count, string text) // возвращаем строку с и друг за другом разместим count раз
{
    int i=0;
    string result = String.Empty; // изначально это пустая строка String.Empty

    while (i< count) // пока i<count делаем ниже
    {
        result = result + text; 
        i++;
    }
    return result;
}

string res = Method4(10, "текст 10 раз, ");// вызываем метод и склеиваем текст 10 раз 
Console.WriteLine(res);
