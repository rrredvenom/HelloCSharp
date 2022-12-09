// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CreateMatrixRndInt(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
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

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return resultArray;
}
int[,] arr1 = new int[3, 4];
int[,] arr2 = new int[3, 4];
Console.WriteLine("Первая матрица:");
CreateMatrixRndInt(arr1);
PrintMatrix(arr1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
CreateMatrixRndInt(arr2);
PrintMatrix(arr2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintMatrix(MultiplyMatrix(arr1, arr2));