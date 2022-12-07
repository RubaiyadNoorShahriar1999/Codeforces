int m = 0, i;
i = Convert.ToInt32(Console.ReadLine());

int[] n = new int[i];

for(int x = 0; x < i; x++)
    n[x] = Convert.ToInt32(Console.ReadLine());


for (int x = 0; x < i; x++)
{
    if (n[x] == 2)
        Console.WriteLine(2);
    else
    {
        m = n[x] % 2;
        Console.WriteLine(m);
    }
}