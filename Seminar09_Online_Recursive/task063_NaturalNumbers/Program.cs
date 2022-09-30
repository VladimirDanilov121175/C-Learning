/* Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
Console.Clear();

string NaturalNumbers(int n)
{
    if (n == 1)
        return $"{n}";
    return NaturalNumbers(n-1) + $" {n}";
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumbers(n));
