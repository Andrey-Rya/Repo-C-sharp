// === Работа с текстом
// Дан текст, в котором нужно все пробелы заменить черточками,
// а маленькие буквы "к" заменить на большие "К", а
// большие "С" заменить на маленькие буквы "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "eжели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + " Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)// text-входной текст, конкретный символ-oldValue, и символ на который будем менять newValue
{
    string result = String.Empty; // пустая строка

    int length = text.Length; // получим длину нашей строки
    for (int i = 0; i < length; i++)
    {
        //если текущ символ text[i] совпал с символом, 
        //который хотим заменить, то результат кладём в новую строку 
        // newValue
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}"; // если совпадений нет в результ добавим текущий символ

    }
    return result;
}

string newText = Replace(text, ' ', '|');// в новом тексте меняем пробелы на |

Console.WriteLine(newText);
// далее меняем  в предыдущем тексте 'к' на 'К'
Console.WriteLine();// пустая строка
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
// далее меняем  в предыдущем тексте 'С' на 'с'
Console.WriteLine();// пустая строка
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
