/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

string DecimalToBinary(int num)
{
    string binary = string.Empty;
    if (num == 0) return "00";

    while (num > 0)
    {
        binary = Convert.ToString(num % 2) + binary;
        num = num / 2;
    }
    return binary;
}

// Альтернативный метод через рекурсию
string DecimalToBinaryRecursive(int num)
{
    if (num == 0 || num == 1) return $"{num}";
    else return DecimalToBinary(num / 2) + num % 2;
}

Console.Write("Введите десятичное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DecimalToBinary(n));
Console.WriteLine(DecimalToBinaryRecursive(n));
