/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */
Console.Clear();

int AddUniqueNumber(int[] tempArray, int number)
{
    bool flag = true;

    foreach (int i in tempArray)
    {
        if(number == i)
            flag = false;
    }

    if (flag == false)
        number = AddUniqueNumber(tempArray, new Random().Next(0, 101));
    return number;
}

void FillAndPrint3DMatrix(int[,,] matr, int height, int width, int depth)
{
    int[] helpArray = new int[height * width * depth];
    for (int i = 0; i < helpArray.Length; i++)
        helpArray[i] = int.MaxValue;

    int helpIndex = 0;
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                matr[x, y, z] = AddUniqueNumber(helpArray, new Random().Next(0, 101));
                Console.WriteLine($"{matr[x, y, z]} [{x}, {y}, {z}]");
                
                helpArray[helpIndex] = matr[x, y, z];
                helpIndex++;
            }
        }
    }
}

Console.WriteLine("Введите размер трехмерного массива [x, y, z]:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Задан трехмерный массив размером [{x}, {y}, {z}]");
int[,,] matrix = new int[x, y, z];

Console.WriteLine("Элементы массива:");
FillAndPrint3DMatrix(matrix, x, y, z);
