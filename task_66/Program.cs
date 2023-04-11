﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна {Summa(m, n)}");


int Summa(int m, int n)
{
    if (n==m) return m;
    return n + Summa(m, n-1);
}