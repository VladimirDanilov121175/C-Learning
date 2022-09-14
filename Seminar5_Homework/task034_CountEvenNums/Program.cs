/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();

int[] arr = new int[new Random().Next(2, 10)];

//  Метод заполнения массива случайными числами
int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

// Метод подсчета четных чисел в массиве
int CountEvenNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(arr)) + "]");
Console.WriteLine("Количество четных чисел в массиве: " + CountEvenNumbersInArray(arr));
