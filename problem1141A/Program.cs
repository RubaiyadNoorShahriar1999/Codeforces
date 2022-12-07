int n, m, ans = 0;
string[] data = Console.ReadLine().Split();
n = Convert.ToInt32(data[0]);
m = Convert.ToInt32(data[1]);

if (n == m)
{
    Console.WriteLine(0);
}
else if (m % n != 0)
{
    Console.WriteLine(-1);
}
else
{
    int d = m / n;
    while (d % 2 == 0)
    {
        d /= 2;
        ans++;
    }
    while (d % 3 == 0)
    {
        d /= 3;
        ans++;
    }
    if (d != 1) 
        ans = -1;

   Console.WriteLine(ans);
}