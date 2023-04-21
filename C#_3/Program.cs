/*Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;
Clear();
Write("Введите число М: ");
int m = int.Parse(ReadLine()!);
Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
Function(m, n);

void Function(int m, int n)
{
    Write(AkkermanFunction(m, n));
}
int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n -1)));
    }
}