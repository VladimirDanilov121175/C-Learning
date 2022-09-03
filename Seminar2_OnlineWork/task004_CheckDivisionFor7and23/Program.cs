/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

void CheckDiv7and23(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("Да, кратно");
    else
    Console.WriteLine("Нет, не кратно");
}

Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

CheckDiv7and23(input);
