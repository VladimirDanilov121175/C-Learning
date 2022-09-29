/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива. */
Console.Clear();

int[,] RangeElementsInRaws(int[,] matr)
{
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1) - 1; y++)
        {
            int min = matr[x, y];
            int minY = y;
            for (int nextY = y + 1; nextY < matr.GetLength(1); nextY++)
            {
                if (matr[x, nextY] < min)
                {
                    min = matr[x, nextY];
                    minY = nextY;
                }
            }
            int temp = matr[x, y];
            matr[x, y] = matr[x, minY];
            matr[x, minY] = temp;
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + "\t");
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matr)
{
    for (int raws = 0; raws < matr.GetLength(0); raws++)
    {
        for (int cols = 0; cols < matr.GetLength(1); cols++)
            matr[raws, cols] = new Random().Next(0, 101);
    }
}

Console.WriteLine("Введите размер двумерного массива [x, y]:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];
Console.WriteLine($"Задан двумерный массив размером [{x}, {y}]");

FillMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(RangeElementsInRaws(matrix));
