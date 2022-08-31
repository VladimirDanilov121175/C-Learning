// Программа нахождения частного двух чисел

Console.WriteLine("Введите первое число: ");
double first = Convert.ToInt32(Console.ReadLine()); // double вместо int, чтобы получать дроби
Console.WriteLine("Введите второе число: ");
double second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(first / second);