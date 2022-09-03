/*
Найти максимальное число в массиве
*/

// Создаем метод по поиску максимального числа из трех
int Max(int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    return max;
}
// Вводим исходные данные
//             0  1   2   3  4     5  6   7    8
int[] arr = {111, 2, 43, 41, 5, 1687, 7, 81, 9872};

// Находим максимальное число
int winner = Max(
                Max(arr[0], arr[1], arr[2]),
                Max(arr[3], arr[4], arr[5]),
                Max(arr[6], arr[7], arr[8])
                );

Console.WriteLine(winner);
