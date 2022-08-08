// Требуется найти элемент find из массива array
int[] array = { 1, 12, 31, 4, 18, 16, 17, 18 }; // определяем новый массив

int n = array.Length; // array.Length определяет количество элементов массива
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // останавливаем - чтобы исключить печать повторяющихся чисел
    }
    index++; // это сокращение от index = index +1
}
