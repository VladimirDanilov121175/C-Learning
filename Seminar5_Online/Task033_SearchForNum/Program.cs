/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
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

// Метод поиска присутствия числа в массиве и выдачи результата
string FindNumberInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]== num)
        return "Число есть в массиве";
    }
    return "Число отсутствует";
}

Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(array)) + "]");

Console.Write("Введите число для поиска: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumberInArray(array, input));
