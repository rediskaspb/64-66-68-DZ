// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void DigitGet(int N, int digit)
{
    if (digit > N)
    {
        return;
    }
    else
    {
        DigitGet(N, digit + 1);
        Console.Write(digit + ", ");
    }
}

int N = ReadInt("Укажите число до которого вывести числа: ");
int digit = 2;
DigitGet(N, digit);
Console.Write("1"); 
