/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

// Приглашение пользователю ввести число
Console.Write("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine());

// Проверяем на остаток
if (n % 2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число нечетное");
