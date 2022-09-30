﻿/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();

int SumOfNaturalNumbers(int m, int n)
{
    if (m == n)
        return m;
    return m += SumOfNaturalNumbers(m + 1, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех чисел {SumOfNaturalNumbers(m, n)}");
