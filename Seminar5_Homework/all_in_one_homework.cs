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

// ****************************************************************
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

    for (int i = 3; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}
Console.WriteLine("Исходный массив [" + string.Join(", ", FillArray(array)) + "]");
Console.WriteLine("Сумма элементов на нечетных позициях в массиве: " + SumUnevenIndexes(array));

// ****************************************************************
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

// ****************************************************************
/* Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность
(сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Первая строка содержит натуральное число N, во второй строке записаны N целых чисел Ai,
а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
Выведите полученную последовательность. 

Примеры:
5
5 3 7 4 6   ->  7 4 6 5 3
3	

5
5 3 7 4 6   -> 4 6 5 3 7
-3	*/
Console.Clear();

// Метод проверки правильности введения числа в пределах указанного диапазона
int CheckWrongInput(int input, int rangeStart, int rangeEnd)
{
    while (input < rangeStart || input > rangeEnd)
    {
        Console.Write($"Число должно быть от {rangeStart} до {rangeEnd}! Повторите ввод: ");
        input = Convert.ToInt32(Console.ReadLine());
    }
    return input;
}

// Метод генерации массива
int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

// Метод сдвига чисел в массиве
void ShiftNumbersInArray(int[] initArr, int shift)
{
    // Создаем новый массив, в который будем записывать сдвинутые элементы
    int[] newArr = new int[initArr.Length];

    // Сдвигаем вправо или влево, в зависимости от введенного значения
    if (shift > 0)
    {
        // Если сдвиг больше чем размер массива, т.е. циклический, узнаем остаток, 
        // он и будет итоговым сдвигом
        shift = shift % initArr.Length;
        int difference = initArr.Length - shift;

        for (int i = 0; i < initArr.Length; i++)
        {
            if (i < shift) newArr[i] = initArr[difference + i];
            else newArr[i] = initArr[i - shift];
        }
    }
    if (shift < 0)
    {
        shift = shift % initArr.Length * -1;
        int difference = initArr.Length - shift;

        for (int i = 0; i < initArr.Length; i++)
        {
            if (i < difference) newArr[i] = initArr[shift + i];
            else newArr[i] = initArr[i - difference];
        }
    }
    Console.WriteLine("Сдвинутый массив выглядит так: [" + string.Join(", ", newArr) + "]");
}

// Вводим входные данные
Console.Write("Введите число элементов последовательности от 1 до 105: ");
int arrLength = CheckWrongInput(Convert.ToInt32(Console.ReadLine()), 1, 105);

Console.Write("Введите величину сдвига от -105 до 105: ");
int inputShift = CheckWrongInput(Convert.ToInt32(Console.ReadLine()), -105, 105);

Console.Clear();

int[] array = GenerateArray(arrLength);
Console.WriteLine("Сгенерирован массив [" + string.Join(", ", array) + "]");
Console.WriteLine($"Задан сдвиг на {inputShift} элемента(ов)");

ShiftNumbersInArray(array, inputShift);
