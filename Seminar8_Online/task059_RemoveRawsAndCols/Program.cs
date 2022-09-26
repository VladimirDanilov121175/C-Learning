/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
строку и столбец, на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
 */

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void RemoveRawsAndCols(int[,] matrix)
{
    int minimum = matrix[0, 0];
    int xMin = 0;
    int yMin = 0;
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (matrix[x, y] < minimum)
            {
                minimum = matrix[x, y];
                xMin = x;
                yMin = y;
            }
        }
    }

    Console.WriteLine($"Будут удалены строка и столбец, содержащие {matrix[xMin, yMin]}");
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (x != xMin && y != yMin)
                Console.Write(matrix[x, y] + "\t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите размер массива: ");
int firstSize = Convert.ToInt32(Console.ReadLine());
int secondSize = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[firstSize, secondSize];
Console.WriteLine($"Задан двумерный массив размером [{firstSize}, {secondSize}]");

FillMatrix(matr);
PrintMatrix(matr);
RemoveRawsAndCols(matr);
