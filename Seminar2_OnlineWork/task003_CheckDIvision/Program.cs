/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.Clear();

void CheckDivision(int num1, int num2)
{
    if (num2 % num1 == 0)
    Console.WriteLine("Кратно");
    else
    Console.WriteLine("Не кратно. Остаток " + (num2 % num1));
}

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());


CheckDivision(first, second);
