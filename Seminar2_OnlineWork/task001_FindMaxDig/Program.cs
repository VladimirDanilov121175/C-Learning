/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/

Console.Clear();    // Очищаем консоль

// Функция по поиску большей цифры в двузначном числе
void FindMaxDig(int num)
{
    int firstDig = num / 10;
    int secondDig = num % 10;
    int max = firstDig;

    Console.WriteLine($"Сгенерировано число {num}");

    if (secondDig > max)
        max = secondDig;
    if (secondDig == firstDig)
        Console.WriteLine("Числа равны");
    else
        Console.WriteLine("Наибольшее число: " + max);
}
// Основная часть программы:
int occasion = new Random().Next(10, 100);
FindMaxDig(occasion);
