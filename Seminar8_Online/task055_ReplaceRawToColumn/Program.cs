/* Задача 55. Задайте двумерный массив. Напишите программу, которая поменяет строки на столбцы и,
если это невозможно, выведет сообщение об этом пользователю */

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
            matrix[i, j] = new Random().Next(-10, 11); ;
    }
}

void ReplaceRawsToStrokes(int[,] matrix)
{

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

Console.WriteLine("Введите размер двумерного массива: ");
int firstSize = Convert.ToInt32(Console.ReadLine());
int secondSize = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[firstSize, secondSize];

if (matr.GetLength(0) != matr.GetLength(1))
    Console.WriteLine("Замена строк на столбцы невозможна с такими значениями");
else
{
    Console.WriteLine($"Задан двумерный массив размером [{firstSize}, {secondSize}]");

    FillMatrix(matr);
    PrintMatrix(matr);
    ReplaceRawsToStrokes(matr);
    PrintMatrix(matr);
}
