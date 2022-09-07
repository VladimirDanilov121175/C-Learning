/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом. */

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

// Первый способ - математический
int fig1 = n / 10000, fig2 = n / 1000 % 10,
    fig4 = n % 100 / 10, fig5 = n % 10;
Console.WriteLine(fig1 + " " + fig2 + " " + fig4 + " " + fig5);

if (fig1 == fig5 && fig2 == fig4)
    Console.WriteLine("Полиндром");
else
    Console.WriteLine("Не полиндром");

// Второй способ - программистский
if (Convert.ToString(n)[0] == Convert.ToString(n)[4] &&
    Convert.ToString(n)[1] == Convert.ToString(n)[3])
    Console.WriteLine("Полиндром");
else
    Console.WriteLine("Не полиндром");
