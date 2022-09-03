/*
Найти максимальное число, используя метод
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
int a1 = 13, b1 = 98, c1 = 34;   // Можно вводить так

int a2 = 74,   // Можно вводить так
    b2 = 6,
    c2 = 1513;

int a3 = -1;   // Можно вводить так
int b3 = -2;
int c3 = 70987;

// Находим максимальное число
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int winner = Max(max1, max2, max3);
Console.WriteLine(winner);
