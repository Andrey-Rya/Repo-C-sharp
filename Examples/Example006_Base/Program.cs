// Решаем задачу с определением самой тяжелой гири
int a = 1; // = это оператор присваивания а не равно
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a; // определяем переменную max, в которую кладем значение первой гири 

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
