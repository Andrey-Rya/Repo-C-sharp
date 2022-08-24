// изучаем двумерные массивы

/*вводим первый двумерный массив со строкой 2 строки и 5 столбцов*/
string[,] table = new string[2, 5]; // 2 строки и 5 столбцов-индексы идут от нуля!!!
//String.Empty  это инициализация строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

table[1,2] = "слово";// указываем наименование массива (1-инд строки, 2-инд столбца)

for (int rows = 0; rows < 2; rows++) // счетчик строк
{
    for (int columns = 0; columns < 5; columns++) // счетчик столбцов
    {
       Console.Write($"-{table[rows, columns]}-");
    }
Console.WriteLine();
}
//===============================================//
Console.WriteLine();
//===============================================//

// метод печатает таблицу на экран и заполняет ее числами


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 -равен цифре 3 в этом массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1-равен цифре 4 в массиве
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// метод заполняет нау матрицу случ числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j< matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1,10) - это полуинтервал
        }
    }
}

int[,] matrix = new int[3, 4];// вводим массив с числами (3-строки и 4-столбца)
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();// пустая строка
PrintArray(matrix);

//============================================//

// выводим матрицу чисел (3-строки и 4-столбца)
// int[,] matrix = new int[3, 4];// вводим массив с числами (3-строки и 4-столбца)

// for (int i = 0; i < matrix.GetLength(0); i++) // 0 -равен цифре 3 в этом массиве
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // 1-равен цифре 4 в массиве
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
// Console.WriteLine();    
// }
