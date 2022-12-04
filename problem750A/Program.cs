int n, k, count = 0,time;
string[] data;
data = Console.ReadLine().Split();
n = Convert.ToInt32(data[0]);
k= Convert.ToInt32(data[1]);
time = 240 - k;
for(int i = 1; i <= n;i++)
{
    if (time / (5 * i) > 0)
    {
        time = time - (5*i);
        count++;
    }
}
Console.WriteLine(count);