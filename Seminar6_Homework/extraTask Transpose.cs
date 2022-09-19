/* Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее
относительно горизонтали.
Первая строка содержит два натуральных числа N и M – количество строк и столбцов матрицы.
В каждой из последующих N строк записаны M целых чисел – элементы матрицы. 
Все числа во входных данных не превышают 100 по абсолютной величине. 
3 4
5 9 2 6         1 2 8 7
6 2 4 3   =>    6 2 4 3
1 2 8 7         5 9 2 6 */
Console.Clear();

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} \t");
        }
    Console.WriteLine();
    }
}

int[,] matrix = new int[5, 5];
// Заполняем матрицу
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 101);
    }
}
PrintMatrix(matrix);

System.Console.WriteLine("Транспонированная матрица:");
// Транспонируем матрицу
for (int i = 0; i <= matrix.GetLength(0) / 2; i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength(1) - 1 - i, j];
        matrix[matrix.GetLength(1) - 1 - i, j] = temp;
    }
}
PrintMatrix(matrix);
