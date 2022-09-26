/* Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

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
            matrix[i, j] = new Random().Next(0, 11);
    }
}

int[] ConvertMatrixToLinearArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
}

int[] CreateHelpArray(int[] array)
{
    int[] helpArr = new int[array.Length];
    int max = 0;
    foreach (int i in array)
        if (i > max) max = i;

    for (int j = 0; j < helpArr.Length; j++)
        helpArr[j] = max + 1;
    return helpArr;
}

void AppearanceFrequency(int[] array)
{
    int[] helpArray = CreateHelpArray(array);

    for (int i = 0; i < array.Length; i++)
    {
        int frequency = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] == array[i])
                frequency++;
        }

        bool flag = true;
        foreach (int el in helpArray)
        {
            if (array[i] == el)
                flag = false;
        }
        if (flag == true)
        {
            Console.WriteLine($"{array[i]} встречается {frequency} раз.");
            helpArray[i] = array[i];
        }
    }
}

Console.WriteLine("Введите размер массива: ");
int firstSize = Convert.ToInt32(Console.ReadLine());
int secondSize = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[firstSize, secondSize];
Console.WriteLine($"Задан двумерный массив размером [{firstSize}, {secondSize}]");

FillMatrix(matr);
PrintMatrix(matr);

AppearanceFrequency(ConvertMatrixToLinearArray(matr));