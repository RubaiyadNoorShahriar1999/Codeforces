int t, m, n;
t = Convert.ToInt32(Console.ReadLine());
List<string> list = new List<string>();
while (t != 0)
{
    string[] data = Console.ReadLine().Split();
    n = Convert.ToInt32(data[0]);
    m = Convert.ToInt32(data[1]);

    if (n % m == 0)
        list.Add("YES");
    else
        list.Add("NO");

    t--;
}

foreach (string s in list)
    Console.WriteLine(s);