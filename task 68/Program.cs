// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerm(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerm(m - 1, 1);
    }
    else
    {
        return Akkerm(m - 1, Akkerm(m, n - 1));
    }
}

int m = ReadInt("Введите значение m: ");
int n = ReadInt("Введите значение n: ");
int funcAkkerman = Akkerm(m, n);

Console.Write($"Функция Аккермана = {funcAkkerman}");