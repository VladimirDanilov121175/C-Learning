/*Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

// Запрос у пользователя двух чисел
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

// Создаем условие проверки, является ли одно число квадратом второго
if (second == first * first || first == second * second)
{
    Console.WriteLine("Да, одно число является квадратом второго");
}
else
 {
    Console.WriteLine("Нет, одно число не является квадратом второго");
 }