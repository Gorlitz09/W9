/*Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
using static System.Console;
Clear();
Write("Введите число М: ");
int m = int.Parse(ReadLine()!);
Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
Sum(m, n);

void Sum(int m, int n)
{
    Write(sum(m - 1, n));
}
int sum(int m, int n)
{
    int num = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        num = m + sum(m, n);
        return num;
    }
}