/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или же указание, что такого элемента нет.
 */
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

void ShowThisElement(int[,] matrix)
{
    Console.Write("Введите номер строки: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x > matrix.GetLength(0) - 1 || y > matrix.GetLength(1) - 1)
        Console.WriteLine("Такого элемента в массиве нет");
    else
        Console.WriteLine($"Под индексом [{x}, {y}] хранится значение {matrix[x, y]}");
}

Console.WriteLine("Задан двумерный массив");
int[,] newMatrix =  {
                    {1, 2, 3, 4, 5},
                    {10, 11, 12, 13, 14},
                    {21, 22, 23, 24, 25},
                    {101, 102, 103, 104, 105}
                    };
PrintMatrix(newMatrix);
ShowThisElement(newMatrix);
