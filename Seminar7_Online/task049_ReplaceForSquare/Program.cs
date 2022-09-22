/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты. */
Console.Clear();

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
            matrix[i, j] = new Random().Next(-10, 11);
    }
    PrintMatrix(matrix);
}

void ReplaceForSquare(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
            matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
    Console.WriteLine("Новый массив:");
    PrintMatrix(matrix);
}

Console.WriteLine("Введите размер массива: ");
int firstSize = Convert.ToInt32(Console.ReadLine());
int secondSize = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[firstSize, secondSize];
Console.WriteLine($"Задан двумерный массив размером [{firstSize}, {secondSize}]");
FillMatrix(matr);
ReplaceForSquare(matr);
