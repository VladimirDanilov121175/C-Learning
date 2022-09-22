/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */
Console.Clear();

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void ShowMeanOfRaw(int[,] matrix)
{
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
        double sum = 0;
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            sum += matrix[x, y];
        }
        Console.WriteLine($"Среднее арифметическое столбца {y} = {sum / matrix.GetLength(0)}");
    }
}

Console.WriteLine("Задан двумерный массив");
int[,] newMatrix =  {
                    {1, 2, 3, 4, 5},
                    {10, 11, 12, 13, 14},
                    {21, 22, 23, 24, 25},
                    {101, 102, 103, 104, 105}
                    };
PrintMatrix(newMatrix);
ShowMeanOfRaw(newMatrix);
