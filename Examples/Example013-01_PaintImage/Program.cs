// Закрашиваем двумерный массив внутри картинки
int[,] pic = new int[,]
{
	{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
	{ 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0,},
	{ 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
	{ 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
	{ 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0,},
	{ 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0,},
	{ 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0,},
	{ 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0,},
	{ 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
	{ 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
	{ 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0,},
	{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
};

// метод вывода нашей картинки
void PrintImage(int[,] image)
{
	for (int i = 0; i < image.GetLength(0); i++)
	{
		for (int j = 0; j < image.GetLength(1); j++)
		{
			//Console.Write($"{image[i, j]}");
			if (image[i, j] == 0) Console.Write($" ");
			else Console.Write($"+");
		}
		Console.WriteLine();
	}
}

// метод закрашивания нашей картинки
void FillImage(int row, int col)
{
	if (pic[row, col] == 0)
	{
		pic[row, col] = 1; // закрашиваем цифрой 1
		FillImage(row - 1, col); // смотрим строку выше
		FillImage(row, col - 1); // смотрим строку слева
		FillImage(row + 1, col); // смотрим строку выше
		FillImage(row, col + 1); // смотрим строку выше
	}
}

PrintImage(pic);
FillImage(6, 6);
PrintImage(pic);


