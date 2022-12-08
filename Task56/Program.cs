// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


int[] SumDigits(int[,] matrix)
{
    int[] sumDigits = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            sumDigits[i] = sum;
        }
        sum = 0;
    }
    return sumDigits;
}

void PrintArray(int[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine(")");
}

(int, int) MinRow(int[] array)
{
    int sumMin = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < sumMin)
        {
            sumMin = array[i];
            result = i;
        }
    }
    return (sumMin, result);
}

int[,] matrix = CreateMatrixRndInt(5, 7, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumDigits = SumDigits(matrix);
PrintArray(sumDigits);
Console.WriteLine();
(int, int) minRow = MinRow(sumDigits);
Console.WriteLine($"Минимальная сумма в строке =  {minRow}");