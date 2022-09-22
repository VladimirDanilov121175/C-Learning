Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
for (int i = 0; i < n; i++)
    arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

int m = Convert.ToInt32(Console.ReadLine());
// int[] arraySecond = new int[n];
bool flag = true;
for (int i = 0; i < n; i++)
{
    int k = 0;
    int x = Convert.ToInt32(Console.ReadLine());
    for (int j = 0; j < m; j++)
    {
        if (arrayFirst[j] == x)
        {
            k++;
        }
    }
    if (k < 1)
        flag = false;

}
if (flag)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");