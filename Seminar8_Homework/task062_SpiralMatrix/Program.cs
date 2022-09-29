/* Задача 62: Заполните спирально массив 4 на 4.
 1,  2,  3, 4
12, 13, 14, 5
11, 16, 15, 6
10,  9,  8, 7
 */
Console.Clear();

int[,] SpiralMatrix(int[,] spiral, int row, int col, int orderNumber)
{
    spiral[row, col] = orderNumber;

    if (row - 1 < 0 || spiral[row - 1, col] != 0)
    {
        if (col + 1 < spiral.GetLength(1) && spiral[row, col + 1] == 0)
            return SpiralMatrix(spiral, row, ++col, ++orderNumber);
    }

    if (row + 1 < spiral.GetLength(0) && spiral[row + 1, col] == 0)
        return SpiralMatrix(spiral, ++row, col, ++orderNumber);

    if (col > 0 && spiral[row, col - 1] == 0)
        return SpiralMatrix(spiral, row, --col, ++orderNumber);

    if (row > 0 && spiral[row - 1, col] == 0)
        return SpiralMatrix(spiral, --row, col, ++orderNumber);

    return spiral;
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

Console.WriteLine($"Задан двумерный массив размером [4, 4]");

int[,] matrix = new int[4, 4];
PrintMatrix(SpiralMatrix(spiral: matrix, row: 0, col: 0, orderNumber: 1));
