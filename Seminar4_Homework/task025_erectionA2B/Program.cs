/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Clear();

Console.Write("Введите основание степени: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральный показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());
while (B <= 0)
    {
        Console.Write("Число должно быть больше 0! Повторите ввод: ");
        B = Convert.ToInt32(Console.ReadLine());
    }

Console.Write($"{A} ^ {B} = {Math.Pow(A, B)}");
