// Узнать индекс элемента в массиве, который ввел пользователь

Console.Write("Введите число из массива: ");
int n = Convert.ToInt32(Console.ReadLine());

//             0   1   2   3  4     5  6   7    8
int[] arr = { 111, 2, 43, 41, 5, 1687, 7, 81, 9872 };
int index = 0;

// Находим индекс
while (index < arr.Length)
{
    if (arr[index] == n)
        Console.WriteLine(index);
    index++;
}
