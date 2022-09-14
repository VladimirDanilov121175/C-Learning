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
    // Создаем новый массив и записываем в него сдвинутые значения
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
    else
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
