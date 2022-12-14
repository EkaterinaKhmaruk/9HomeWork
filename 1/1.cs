/*Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int number = ReadInt("Введите N: ");
NaturalNumber(number);

void NaturalNumber(int n)
{
if (n < 0)
{
Console.Write("число должно быть больше 1");

}
if (n > 0)
{
Console.Write($"{n} ");
NaturalNumber(n - 1);
}
if (n == 1)
{
Console.Write("");
}
}


int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
