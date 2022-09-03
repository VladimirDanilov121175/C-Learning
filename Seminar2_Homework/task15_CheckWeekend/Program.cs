/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/
Console.Clear();

void CheckWeekend(int number)
{
    if (number > 5)
        Console.WriteLine("Weekend!");
    else
        Console.WriteLine("Working day :(");
}

Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

while (day < 1 || day > 7)
{
    Console.Write("Цифры должны быть от 1 до 7! Повторите ввод: ");
    day = Convert.ToInt32(Console.ReadLine());
}
CheckWeekend(day);
