/* Дан текст. В тексте нужно все пробелы заменить вертикальными черточками,
маленькие буквы “к” заменить большими “К”, а большие “В” заменить
маленькими “в”. */
Console.Clear();

string text = "— Я думаю, — сказал князь, улыбаясь, — что, " +
                "ежели бы вас послали вместо нашего милого " +
                "Винценгероде, вы бы взяли приступом согласие " +
                "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// Метод для замены одного символа в тексте на другой
string ChangeChars(string oldText, char oldChar, char newChar)
{
    string newText = String.Empty;
    for (int i = 0; i < oldText.Length; i++)
    {
        if (oldText[i] == oldChar)
            newText += newChar;
        else
            newText += oldText[i];
    }
    return newText;
}

// Вызываем метод, передавая туда символы на замену
string alteredText = ChangeChars(text, ' ', '|');
Console.WriteLine(alteredText);
Console.WriteLine();

alteredText = ChangeChars(alteredText, 'к', 'К');
Console.WriteLine(alteredText);
Console.WriteLine();

alteredText = ChangeChars(alteredText, 'В', 'в');
Console.WriteLine(alteredText);
Console.WriteLine();
