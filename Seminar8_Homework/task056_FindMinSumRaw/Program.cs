/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов. */
Console.Clear();

/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива. */
Console.Clear();

void FindRawWithMinSum(int[,] matr)
{
    int minSum = int.MaxValue;
    int minSumIndex = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int rawSum = 0;
        
        for (int j = 0; j < matr.GetLength(1); j++)
            rawSum += matr[i, j];

        if (rawSum < minSum)
        {
            minSum = rawSum;
            minSumIndex = i;
        }
        Console.WriteLine($"Сумма элементов в строке {i} = {rawSum}");
    }
    Console.WriteLine($"Минимальная сумма элементов в строке {minSumIndex}");
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
FindRawWithMinSum(matrix);
