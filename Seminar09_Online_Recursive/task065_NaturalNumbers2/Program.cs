/* Задача 65: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */
Console.Clear();

string NaturalNumbers(int m, int n)
{
    if (m == n)
        return $"{m}";
    return NaturalNumbers(m, n-1) + $" {n}";
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumbers(m, n));
