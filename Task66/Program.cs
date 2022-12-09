// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
M = M - 1;
int SumNumbers(int M, int N)
{

    if (N == M)
    {
        return 0;
    }
    return N + SumNumbers(M, N - 1);
}
Console.WriteLine($"Сумма чисел от M до N равна : {SumNumbers(M, N)}");