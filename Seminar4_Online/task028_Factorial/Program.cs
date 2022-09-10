/* Напишите программу, которая принимает на вход число N
и выдаёт произведение чисел от 1 до N. */

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 2; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine(factorial);
