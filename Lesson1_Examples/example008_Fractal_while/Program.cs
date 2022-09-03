﻿// Необходимо проставить в консоле три точки (вершины треугольника). 
// Потом взять любые две точки и, проведя между ними условную линию, 
// поставить точку посредине между ними.
// Потом выбрать случайную вершину треугольника и, соединив с новой точкой,
// поставить еще одну точку посредине между ними. 
// И т.д. 10 раз, 100 раз, 1000 раз.
// Что получится в итоге? Напишите для этого программу.

// - **Алгоритм создания программы**
//     1. Поставить три точки
//     2. Взять 2 случайные точки
//     3. Найти середину между точками
//     4. Поставить точку
//     5. Выбрать случайную вершину треугольника
//     6. Соединить вершину с полученной на 4 шаге точкой
//     7. Повторить шаги с 3 по 7 заданное количество раз - 10, 100, 1000 и т.д.

Console.Clear(); // Очищает консоль. Необязательно, но удобно

int xa = 40, ya = 1; // задаем координаты первой вершины
Console.SetCursorPosition(xa, ya); // Задаем первую вершину
Console.WriteLine("+");
// Задаем вторую вершину
int xb = 0, yb = 37;
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
// Третья вершина
int xc = 80, yc = 37;
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// Создаем цикл, в котором каждый раз берется случайная вершина треугольника
// и вновь созданная точка, потом в середину между ними ставится новая точка

int x = xa, y = ya; // задаем начальные координаты "новой точки"
int count = 0; // счетчик

while (count <= 10000)
{
    int triangle = new Random().Next(0, 3); // Выбираем случайную вершину

    if (triangle == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    else if (triangle == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    else if (triangle == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    count++;
}

