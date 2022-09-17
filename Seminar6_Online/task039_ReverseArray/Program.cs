/*Задача 39: Переворот массива*/

int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] newArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
    newArray[i] = array[array.Length - i - 1];

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("[" + string.Join(", ", newArray) + "]");
for (int i = 0; i < 21; i++)
    Console.Write("*");

Console.WriteLine();
Console.WriteLine("Альтернативный вариант");
// Вариант со взаимной заменой позиций
for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
