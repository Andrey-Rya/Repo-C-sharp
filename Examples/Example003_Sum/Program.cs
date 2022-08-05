// Программа сложения 2-х целых чисел
int numberA = 3; // определим переменную (int-целые числа) и положим в нее чило 3
// скажем компьютеру сколько памяти нужно под это число выделить
int numberB = 5;
Console.WriteLine(numberA + numberB);

// Второй вариант сложения 2-х целых чисел
int numberAA = 31;
int numberBB = 5;
int result = numberAA + numberBB;
Console.WriteLine(result);

// Выполняем сложение двух случайных чисел
int numberAAA = new Random().Next(1, 10); // добавим случ число от 1 до 9
Console.WriteLine(numberAAA); // смотрим первое число
int numberBBB = new Random().Next(1, 10); // добавим случ число от 1 до 9
Console.WriteLine(numberBBB); // смотрим второе число
int result1 = numberAAA + numberBBB;
Console.WriteLine(result1);
