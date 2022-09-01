/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

// Приглашение пользователю ввести три числа
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int third = Convert.ToInt32(Console.ReadLine());

int max = first;

// Сравниваем числа и выдаем в консоль максимальное из них
if (second > max)
    max = second;
if (third > max)
    max = third;
if (first == second && third == first)
    Console.WriteLine("Все числа равны");
else
    Console.Write("Максимальное число: " + max);