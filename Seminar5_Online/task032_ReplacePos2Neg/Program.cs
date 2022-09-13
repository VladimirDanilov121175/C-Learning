/* Задача 32: Напишите программу замены элементов массива: положительные элементы замените
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
 */
Console.Clear();

int[] array = new int[12];

//  Метод заполнения массива случайными числами
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-9, 10);
    return arr;
}

// Метод замены положительных чисел на отрицательные и наоборот
int[] ReplacePosNeg(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(array)) + "]");
Console.WriteLine("Конечный массив [" + string.Join(", ", ReplacePosNeg(array)) + "]");
