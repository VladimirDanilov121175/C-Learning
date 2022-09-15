// string[,] table = new string[5, 10];
// table[1, 7] = "table";

// for (int i = 0; i < 5; i++)   // для строк
// {
//     for(int j = 0; j < 10; j++) // для столбцов
//         Console.Write("," + table[i, j]);
//     Console.WriteLine();
// }   


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            // if (matr[i, j] == 0) Console.Write("*");
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(0, 10);
    }
}

int[,] matrix = new int[5, 10];
FillArray(matrix);
PrintArray(matrix);
