// Заполнить массив набором случайных чисел и вывести числа в консоль.
// Кроме того вывести в консоль индекс определенного числа

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

// Метод нахождения индекса числа. Обратить внимание, что это уже не void method,
// так как метод возвращает результат

int FindIndex(int[] array, int find)
{
    int pos = -1; // Изящное решение программистов показать отсутствие числа в массиве

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            pos = i;
            break;   // для одинаковых чисел в массиве, чтобы вывелся самый первый результат
        }
    }
    return pos;

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

Console.WriteLine();   // Задаем пустую строку, чтобы отделить

// Находим и выводим индекс определенного числа
int find = FindIndex(arr, 13);
Console.WriteLine(find);



