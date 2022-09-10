/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом. */

Console.Clear();

Console.Write("Введите пятизначное число: ");
string n = Console.ReadLine();
Console.WriteLine(n);

if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine("Полиндром");
else Console.WriteLine("Не полиндром");
