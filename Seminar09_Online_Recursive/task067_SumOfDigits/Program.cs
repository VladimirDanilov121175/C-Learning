/* Задача 67: Напишите программу, которая будет принимать на вход число
и возвращать сумму его цифр.
453 -> 12
45 -> 9 */
Console.Clear();

string SumOfAllDigits(int number, int sum)
{
    if(number < 10)
        return $"Сумма всех цифр в числе = {sum += number}";

    return SumOfAllDigits(number / 10, sum += number % 10);
}

Console.Write("Введите число, в котором 2 или более цифр: ");
int input = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.WriteLine(SumOfAllDigits(input, sum));
