int n,count = 0;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[1000000];

for (int i = 0; i < n; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    if (a[i] != a[i + 1])
        count++;
}
Console.WriteLine(count);