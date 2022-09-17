/* Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше
суммы двух других сторон. */
Console.Clear();

Console.Write("Введите три стороны треугольника a, b, c: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"a = {a}, b = {b}, c = {c}.");

// Проверка возможности существования такого треугольника
if (a < b + c && b < c + a && c < a + b)
    Console.WriteLine("Такой треугольник возможен");
else Console.WriteLine("Треугольник с такими сторонами невозможен");
