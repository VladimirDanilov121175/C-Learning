/*Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

// Метод генерации случайных чисел. Можно и не выводить в отдельный метод.
int GenerateRandomNumbers()
{
    int n = new Random().Next(100, 1000);
    return n;
}

// Метод для удаления второй цифры из трехзначного числа
void DelSecondDigit()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine($" Generated number {n}");
    int a = n / 100 * 10;
    int b = n % 10;
    int newNum = (a + b);
    Console.WriteLine($"Your new number is {newNum}");
}

// Альтернативный способ, основанный на конвертации в string и конкатенации по индексу символа.
// При этом надо учитывать, что выводимый тип данных будет тоже string, а не int.
// void DelSecondDigit()
// {
//     int n = GenerateRandomNumbers();
//     Console.WriteLine($" Generated number {n}");
//     Console.WriteLine($"Your new number is {Convert.ToString(n)[0]}{Convert.ToString(n)[2]}");
// }

DelSecondDigit();
