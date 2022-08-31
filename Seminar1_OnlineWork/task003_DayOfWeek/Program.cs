/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

Console.Write("Введите число, соответствующее дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Это понедельник");
}
else if (num == 2)
{
    Console.WriteLine("Это вторник");
}
else if (num == 3)
{
    Console.WriteLine("Это среда");
}
else if (num == 4)
{
    Console.WriteLine("Это четверг");
}
else if (num == 5)
{
    Console.WriteLine("Это пятница");
}
else if (num == 6)
{
    Console.WriteLine("Это суббота");
}
else
{
    Console.WriteLine("Это воскресенье");
}
