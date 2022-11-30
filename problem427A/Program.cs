int n;
n = Convert.ToInt32(Console.ReadLine());
int curoff = 0;
int untreated = 0;
string[] data;
data = Console.ReadLine().Split();


for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(data[i]);
    if (x > 0)
    {
        curoff += x;

    }
    else
    {
        if (curoff < 1)
        {
            ++untreated;
        }
        else
        {
            --curoff;
        }
    }
}
Console.WriteLine(untreated);
