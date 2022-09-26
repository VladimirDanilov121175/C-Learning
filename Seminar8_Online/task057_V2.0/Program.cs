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

    for (int k = 0; k < array.Length - 1; k++)
    {
        int minIndex = k;
        for (int l = k + 1; l < array.Length; l++)
        {
            if (array[l] < array[minIndex])
                minIndex = l;
        }
        int temp = array[minIndex];
        array[minIndex] = array[k];
        array[k] = temp;
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}


void AppearanceFrequency(int[] array)
{
    int frequency = 1;
    for (int i = 1; i < array.Length; i++)
    {
        bool flag = true;

        if (array[i] == array[i - 1])
            frequency++;
        else
            flag = false;

        if (flag == false)
        {
            Console.WriteLine($"{array[i - 1]} встречается {frequency} раз(а).");
            frequency = 1;

            if (array[i] == array[array.Length - 1])
                Console.WriteLine($"{array[i]} встречается {array.Length - i} раз(а).");
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