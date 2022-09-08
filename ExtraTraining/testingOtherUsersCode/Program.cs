string Method4(int count, char symbol)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + symbol;
    }
    return result;
}

string res = Method4(10, 'Z');
Console.WriteLine(res);
