/* Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки
символов данной строки.
Строка состоит из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.
Выведите в каждой строке по одной перестановке. Перестановки можно выводить в любом порядке.
Повторений и строк, не являющихся перестановками исходной, быть не должно. */

int Fractal(int input)
{
    if (input == 1) return 1;
    return input * Fractal(input - 1);
}

string ShiftSymbols(string text, int shiftValue)
{
    if (shiftValue == 0) return text;
    else
    {
        string newText = string.Empty;
        for (int i = 0; i < text.Length; i++)
            if (i < shiftValue)
                newText += text[text.Length - shiftValue + i];
            else
                newText += text[i - shiftValue];
        return newText;
    }
}

void PrintPossibleVariants(string rightSymbols, string leftSymbols)
{
    if (rightSymbols == string.Empty)
        Console.Write(leftSymbols + " ");

    for (int i = 0; i < leftSymbols.Length; i++)
    {
        string newVariant = ShiftSymbols(leftSymbols, i);
        if (newVariant != leftSymbols)
            System.Console.Write(rightSymbols + newVariant + " ");

        string newRight = rightSymbols + newVariant[0];
        string newLeft = string.Empty;
        for (int k = 1; k < newVariant.Length; k++)
            newLeft += newVariant[k];

        PrintPossibleVariants(newRight, newLeft);
    }
}


Console.Write("Введите от 1 до 8 символов: ");
string input = Console.ReadLine();

int fractal = Fractal(input.Length);
Console.WriteLine($"Возможных вариантов {fractal}");

PrintPossibleVariants(string.Empty, input);
