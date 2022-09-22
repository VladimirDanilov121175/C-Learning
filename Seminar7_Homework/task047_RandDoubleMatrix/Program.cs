/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.Clear();

double[,] CreateMatrix()
{
    Console.WriteLine("Введите последовательно размер двумерного массива");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());

    double[,] matrix = new double[x, y];
    Console.WriteLine($"Задан двумерный массив размером [{x}, {y}]");
    Console.WriteLine();

    return matrix;
}

void FillMatrixWithRealNumbers(double[,] matrix)
{
    int randomizer;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            randomizer = new Random().Next(0, 3);
            
            matrix[i, j] = Math.Round(new Random().Next(-10, 11)
                         + new Random().NextDouble(), randomizer);
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

double[,] newMatrix = CreateMatrix();
FillMatrixWithRealNumbers(newMatrix);
PrintMatrix(newMatrix);
