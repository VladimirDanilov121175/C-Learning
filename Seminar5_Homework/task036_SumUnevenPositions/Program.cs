/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();

int[] array = new int[new Random().Next(2, 11)];

// Метод заполнения массива случайными числами
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(0, 11);
    return arr;
}

// Метод подсчета суммы элементов на нечетных позициях
int SumUnevenIndexes(int[] arr)
{
    int sum = arr[1];
    
    for (int i = 3; i < arr.Length; i+=2)
        sum += arr[i];
    return sum;
}
Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(array)) + "]");
Console.WriteLine("Сумма элементов на нечетных позициях в массиве: " + SumUnevenIndexes(array));
