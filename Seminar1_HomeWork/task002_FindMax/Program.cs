/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

// Приглашение пользователю ввести два числа
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

// Сравниваем и выводим введенные числа
if (first > second)
    Console.Write("Максимальное число: " + first);
else if (first == second)
    Console.Write("Числа равны");
else
    Console.Write("Максимальное число: " + second);
