// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumNat(int M, int N, int sum)
{
    sum = sum + N;
    if (N <= M)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N = {sum} ");
        return;
    }
    SumNat(M, N - 1, sum);
}

int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");
int step = M;

SumNat(M, N, step = 0);