// Заполнить массив набором случайных чисел и вывести числа в консоль

// Создаем метод заполнения массива случайными числами
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        int arrNum = new Random().Next(1, 100);
        array[index] = arrNum;
        index++;
    }
}

// Метод вывода чисел массива в консоль
void PrintArray(int[] filledArray)
{
    for (int i = 0; i < filledArray.Length; i++)
        Console.WriteLine(filledArray[i]);
}

// Задаем произвольный массив
int[] arr = new int[10];

// Запускаем методы
FillArray(arr);
PrintArray(arr);
