int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

int count = 0;
int count_max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
    
    if (array[i] < 0)
        count = 0;
    
    if (count_max < count)
        count_max = count;
}
Console.WriteLine(count_max);
