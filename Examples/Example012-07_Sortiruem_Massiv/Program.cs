// сортируем массив по возростанию цифр

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // исходный массив

// выводим данный массив на экран - void
void PrintArray(int[] array)// массив в качестве аргумента
{
    int count = array.Length;// счетчик = длине массива
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");// вывод [i] символа массива в строку
    }
    Console.WriteLine();
} 

// метод упорядочивания массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i; // запоминаем позицию элемента с которым будем что-то делать
        //
        for (int j = i +1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;

        }
        int temporary = array[i];// находиам индекс позиции элемента
        array[i] = array[minPosition];// сюда кладем найденный элемент
        array[minPosition] = temporary; //кладем временный элемент в эту пеозицию
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
