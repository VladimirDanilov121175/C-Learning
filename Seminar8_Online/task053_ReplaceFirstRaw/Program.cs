/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
и последнюю строки массива */

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
            matrix[i, j] = new Random().Next(-10, 11);;
    }
}

void ReplaceRaws(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) -1, i];
        matrix[matrix.GetLength(0) -1, i] = temp;
    }
}
Console.WriteLine("Введите размер массива: ");
int firstSize = Convert.ToInt32(Console.ReadLine());
int secondSize = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[firstSize, secondSize];
Console.WriteLine($"Задан двумерный массив размером [{firstSize}, {secondSize}]");

FillMatrix(matr);
PrintMatrix(matr);
ReplaceRaws(matr);
PrintMatrix(matr);
