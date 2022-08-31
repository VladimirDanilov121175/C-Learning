// Программа для нахождения квадрата введенного числа

Console.Write("Введите число, чтобы узнать его квадрат: ");
double num = Convert.ToDouble(Console.ReadLine()); // double, чтобы можно было вводить дроби
double square = num * num;
Console.WriteLine(square); 