/* Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y) */

Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 4)
{
    Console.WriteLine("Число должно быть от 1 до 4! Повторите ввод: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n == 1)
    Console.WriteLine("x от 0 до бесконечности, y от 0 до бесконечности");
else if (n == 2)
    Console.WriteLine("x от 0 до минус бесконечности, y от 0 до бесконечности");
else if (n == 3)
Console.WriteLine("x от 0 до минус бесконечности, y от 0 до минус бесконечности");
else
    Console.WriteLine("x от 0 до бесконечности, y от 0 до минус бесконечности");

