// работаем с генератором случайных чисел
void FillArray(int[] collection)
{
    int lenght = collection.Length; //получили длину массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // кладем в поз index новое случ число от 1 до 10
        index++;
    } 
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 - такой элемент не найден в массиве
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // new int[10]-создать новый массив из 10ти эл-тов (нули)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);

