int t;
List<int> list = new List<int>();
t = Convert.ToInt32(Console.ReadLine());

while (t != 0)
{
    string[] data1 = Console.ReadLine().Split();
    int b, p, f;
    b = Convert.ToInt32(data1[0]);
    p = Convert.ToInt32(data1[1]);
    f = Convert.ToInt32(data1[2]);

    string[] data2 = Console.ReadLine().Split();
    int h, c;
    h = Convert.ToInt32(data2[0]);
    c = Convert.ToInt32(data2[1]);
    int ans = 0;
    if (h > c)
    {
        ans += h * Math.Min(b / 2, p);
        b -= 2 * Math.Min(b / 2, p);
        ans += c * Math.Min(b / 2, f);
        b -= 2 * Math.Min(b / 2, f);
    }
    else
    {
        ans += c * Math.Min(b / 2, f);
        b -= 2 * Math.Min(b / 2, f);
        ans += h * Math.Min(b / 2, p);
        b -= 2 * Math.Min(b / 2, p);
    }

    list.Add(ans);
    t--;
}

foreach (var a in list)
    Console.WriteLine(a);
