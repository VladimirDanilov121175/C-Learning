/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит
число А в целую степень B с помощью рекурсии. */
Console.Clear();

int RaiseToDegree(int number, int degree)
{
    if (degree == 1)
        return number;
    
    return RaiseToDegree(number, degree - 1) * number;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(RaiseToDegree(n, d));
