/* Задача 61. Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника */
Console.Clear();

Console.Write("Введите число строк треугольника Паскаля: ");
int raws = Convert.ToInt32(Console.ReadLine());

int[,] triangle = new int[raws, raws];
for (int x = 0; x < triangle.GetLength(0); x++)
{
    for (int space = triangle.GetLength(0) - 1 - x; space >= 0; space--)
        Console.Write("  ");
    for (int y = 0; y <= x; y++)
    {
        if (y == 0 || y == x)
            triangle[x, y] = 1;
        else
            triangle[x, y] = triangle[x - 1, y] + triangle[x - 1, y - 1];

        if (triangle[x, y] >= 10)
            Console.Write(triangle[x, y] + "  ");
        else
            Console.Write(triangle[x, y] + "   ");

    }
    Console.WriteLine();
}