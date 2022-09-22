/* Два массива считаются похожими, если они состоят из одних и тех же элементов (без учета кратности).
По двум массивам выясните, похожи ли они.
[1, 9, 7, 7] и [7, 9, 9, 1, 1, 7]  - ДА
[1, 9, 7, 7, 7] и [2, 9, 7, 7, 7] - НЕТ
*/
Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = int.Parse(Console.ReadLine());
}

string CompareArrays(int[] array1, int[] array2)
{
    // bool flag = true;
    for (int i = 0; i < array1.Length; i++)
    {
        int counter = 0;
        for (int j = 0; j < array2.Length; j++)
        {
            if (array1[i] == array2[j])
                counter++;
        }
        if (counter < 1)
            return "Массивы не похожи";
    }
    return "Массивы похожи";
}

int[] first = new int[3];
int[] second = new int[4];

Console.WriteLine("Введите все элементы массива по порядку: ");
InputArray(first);
Console.WriteLine("Введите элементы второго массива: ");
InputArray(second);
Console.WriteLine($"Заданы массивы [{string.Join(", ", first)}] и [{string.Join(", ", second)}]");

Console.WriteLine(CompareArrays(first, second));
