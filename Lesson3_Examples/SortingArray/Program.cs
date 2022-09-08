/* Программа сортировки чисел "методом выбора" (метод мини-макса) */
Console.Clear();

// Метод заполнения массива случайными  числами
void FillArray(int[] array)
{
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

// Метод вывода чисел массива в консоль
void PrintArray(int[] filledArray)
{
    for (int i = 0; i < filledArray.Length; i++)
    {
        Console.Write($"{filledArray[i]} ");
    }
    Console.WriteLine();
}

// Сортировка чисел в массиве
void OrderArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex]) minIndex = j;
        }
        int temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
    }
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
OrderArray(arr);
PrintArray(arr);
