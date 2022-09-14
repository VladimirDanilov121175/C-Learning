/* Задача 38: Задайте массив дробных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3,5 7,78 22 2,23 78, 25] -> 76,02 */
Console.Clear();

double[] arr = new double[new Random().Next(3, 11)];

// Метод заполнения массива случайными числами
double[] FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        // {
        //     double randNum = new Random().Next(100);
        //     array[i] = randNum + Convert.ToDouble(new Random().Next(100)) / 100;
        // }

        array[i] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
    return array;
}

Console.WriteLine("Исходный массив [" + string.Join("; ", FillArray(arr)) + "]");

// Находим мин и макс в массиве
double max = arr[0], min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}
Console.WriteLine("Максимальное число в массиве " + max + ", минимальное " + min);
Console.WriteLine($"Разница чисел {max} - {min} = {max - min}");
