/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0, и выдаёт номер четверти плоскости, в которой находится эта точка. */

// Метод страховки от введения нуля
int CheckForZeroInput(int input)
{
    while (input == 0)
    {
        Console.Write("Число не должно быть 0! Повторите ввод: ");
        input = Convert.ToInt32(Console.ReadLine());
    }
    return input;
}

Console.WriteLine("Введите x, отличный от 0: ");
int x = CheckForZeroInput(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите y, отличный от 0: ");
int y = CheckForZeroInput(Convert.ToInt32(Console.ReadLine()));

Console.Write($"Введена координатная точка ({x}, {y}). Это ");

if (x > 0)
{
    if (y > 0)
        Console.WriteLine("первая четверть.");
    else
        Console.WriteLine("четвертая четверть.");
}
else
if (y > 0)
    Console.WriteLine("вторая четверть.");
else
    Console.WriteLine("третья четверть.");
