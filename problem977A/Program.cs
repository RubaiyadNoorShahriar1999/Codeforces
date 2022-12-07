int n, k, rem, i;
string[] data = Console.ReadLine().Split();
n = Convert.ToInt32(data[0]);
k = Convert.ToInt32(data[1]);

for (i = 1; i <= k; i++)
{
    rem = n % 10;

    if (rem == 0)
        n /= 10;
    else
        n -= 1;
}
Console.WriteLine(n);