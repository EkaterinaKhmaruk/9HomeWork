/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
Console.WriteLine();
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"Сумма от {m} до {n}: ");
Sum(m, n, temp = 0);

int ReadInt(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Sum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"{sum}");
        return;
    }
    Sum(m, n - 1, sum);
}
