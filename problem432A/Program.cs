int n, k , count = 0;

string[] data = new string[2];
data = Console.ReadLine().Split();
n = Convert.ToInt32(data[0]);
k = Convert.ToInt32(data[1]);

int[] a = new int[n];

string[] data2 = new string[n];
data2 = Console.ReadLine().Split();

for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(data2[i]);
}

for(int i = 0; i < n; i++)
{
    if (a[i] < 5)
    {
        if(5 - a[i] >= k)
        {
            count++;
        }
    }
}

if(count >= 3)
{
    Console.WriteLine(count / 3);
}
else
{
    Console.WriteLine(0);
}