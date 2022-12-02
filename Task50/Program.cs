// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j], 4} ");
            
        }
            Console.WriteLine("|");
    }
}

void FindArrayElement(int[,] array)
{
    Console.WriteLine("Введите номер строки:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int y = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x-1 && j == y-1)
            {
                Console.WriteLine($"Элемент с такими индексами = {array[i, j]} ");
            }
        }
    }
    if (x >array.GetLength(0) || y > array.GetLength(1))
    {
        Console.Write("Элемента с такими индексами в массиве нет");
    }
}

int[,] matrix = CreateMatrixRndInt(5, 6, 1, 10);
PrintMatrix(matrix);
FindArrayElement(matrix);