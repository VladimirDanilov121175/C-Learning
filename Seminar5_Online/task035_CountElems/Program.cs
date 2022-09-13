/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
 */
Console.Clear();

int[] array = new int[123];

//  Метод заполнения массива случайными числами
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-1000, 1000);
    return arr;
}

// Метод подсчета количества элементов со значениями [10, 99]
int CountElems10To99(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count++;
    }
    return count;
}

Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(array)) + "]");
Console.WriteLine("Число элементов со значениями [10, 99] в массиве: " + CountElems10To99(array));
