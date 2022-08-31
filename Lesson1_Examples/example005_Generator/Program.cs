// Программа нахождения суммы двух случайных чисел
// через оператор new Random().Next();
// Next задает диапазон, в котором будут генерироваться числа, при этом
// последнее число диапазона выдает число всегда меньше на 1, т.е.
// (min, max-1)

int first = new Random().Next(1, 101);
Console.WriteLine(first);
int second = new Random().Next(1, 101);
Console.WriteLine(second);
Console.WriteLine(first + second);