/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
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

// Метод нахождения суммы положительных чисел
int SumPositive(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sum += arr[i];
    }
        return sum;
}

//  Метод нахождения суммы отрицательных чисел
int SumNegative(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }
        return sum;
}

Console.WriteLine("Задан массив [" + string.Join(", ", FillArray(array)) + "]");
Console.WriteLine("Сумма положительных чисел в массиве " + SumPositive(array));
Console.WriteLine("Сумма отрицательных чисел в массиве " + SumNegative(array));
