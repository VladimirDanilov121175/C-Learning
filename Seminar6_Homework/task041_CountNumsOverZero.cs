/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();


int[] input = new int[10];
int count = 0;
string print = string.Empty;

Console.WriteLine("Введите десять любых чисел, как положительных, так и отрицательных: ");
for (int i = 0; i < input.Length; i++)
{
    input[i] = int.Parse(Console.ReadLine());
    if (input[i] > 0) count++;
    
    print += input[i] + " ";
    Console.Clear();
    Console.Write(print);

}
Console.WriteLine($"Количество чисел больше нуля {count}");
