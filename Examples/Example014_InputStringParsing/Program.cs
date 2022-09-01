// Урок 6: написать парсинг входной строки. Увеличить в 2 раза 
// каждую координату

using System.Linq;
                
string text = "(1,2) (2,3) (4,5) (6,7)";

var data = text.Split(" ")

                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}

