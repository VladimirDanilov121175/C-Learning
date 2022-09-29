/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
произведение двух матриц. */
Console.Clear();

int[,] ProductOfTwoMatrixes(int[,] matr1, int[,] matr2)
{
    int[,] productOfTwoMatrixes = new int[matr1.GetLength(0), matr1.GetLength(1)];

    for (int raws = 0; raws < productOfTwoMatrixes.GetLength(0); raws++)
    {
        for (int cols = 0; cols < productOfTwoMatrixes.GetLength(1); cols++)
            productOfTwoMatrixes[raws, cols] = matr1[raws, cols] * matr2[raws, cols];
    }
    return productOfTwoMatrixes;
}

void PrintMatrix(int[,] matr)
{
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

Console.WriteLine("Введите размер двух двумерных массивов [x, y]:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Заданы двумерный массив размером [{x}, {y}]");
Console.WriteLine();

int[,] matrix1 = new int[x, y];
int[,] matrix2 = new int[x, y];

FillMatrix(matrix1);
FillMatrix(matrix2);

Console.WriteLine("Первый массив:");
PrintMatrix(matrix1);

Console.WriteLine("Второй массив:");
PrintMatrix(matrix2);

Console.WriteLine("Произведение двух массивов:");
PrintMatrix(ProductOfTwoMatrixes(matrix1, matrix2));
