using System.Collections.Generic;

int t, a, b;
List<int> list = new List<int>();
t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] data = Console.ReadLine().Split();
    a = Convert.ToInt32(data[0]);
    b = Convert.ToInt32(data[1]);

    if (a == b)
        list.Add(0);
    else
    {
        int greater = (a > b ? a : b);
        int less = (a > b ? b : a);
        list.Add(Math.Abs(greater - less) / 10 + (Math.Abs(greater - less) % 10 > 0 ? 1 : 0));
    }
}
foreach (int x in list)
    Console.WriteLine(x);