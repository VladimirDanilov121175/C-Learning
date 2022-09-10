/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
Console.Clear();

Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (input > 0)
{
    sum += input % 10;
    input /= 10;
}
Console.WriteLine($"Сумма всех цифр в данном числе {sum}");
