// нахождение середин отрезков данных точек от 3 до бесконечности и соединение их
Console.Clear(); // команда очистки консоли нашего лоокального терминала
//Console.SetCursorPosition(10, 4); // указываем отступ от лев края и отступ от правого края в символах 
//Console.WriteLine("+");

// Определяем вершины треугольника (отступы по х и y)
int xa = 30, ya = 1;
int xb = 1, yb = 13;
int xc = 60, yc = 13;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// далее программа с алгоритмом повтора
int x = xa, y = xb; // опред случ точку с координатами первой точки
int count = 0; // устанавливаю в начало счетчик количества нахождения отрезков и деления пополам
// счетчик менее числа указанного здесь
while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0,3) генерируем случ число от 0 до 2 вкл
    if(what == 0)
    {
        x = (x + xa) / 2; // находим середину отрезка
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2; 
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y); // установка курсора в нужную позицию
    Console.WriteLine("+");
    count = count + 1; // чтобы цикл не ушел в бесконечность прописываем увеличение счетч
    // count +=1; - второй вариант написаний увеличения счетчика на 1
    // count++; - третий вариант написаний увеличения счетчика на 1
}
//конец программы