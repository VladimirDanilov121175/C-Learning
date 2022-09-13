/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 9
[6 7 3 6] -> 36 21
 */
Console.Clear();

int[] array = new int[5];

//  Метод заполнения массива случайными числами
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 11);
    return arr;
}

// Метод произведения пар чисел в массиве и записи в новый массив
void NewArray(int[] arr)
{
    int newLength = arr.Length / 2;
    if (arr.Length % 2 != 0)
        newLength = newLength + 1;

    int[] newArray = new int[newLength];   // new array
    for (int i = 0; i < newLength; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    Console.WriteLine("Конечный массив [" + string.Join(", ", newArray) + "]");
}

Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(array)) + "]");
NewArray(array);

