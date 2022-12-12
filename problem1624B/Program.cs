int t = Convert.ToInt32(Console.ReadLine());
List<string> list = new List<string>();
while (t != 0)
{
    int a, b, c, m = -1;
    string[] data = Console.ReadLine().Split();
    a = Convert.ToInt32(data[0]);
    b = Convert.ToInt32(data[1]);
    c = Convert.ToInt32(data[2]);

    if ((2 * b - c) % a == 0 && (2 * b - c) > 0)
        m = (2 * b - c) / a;

    else if ((a + c) % (2 * b) == 0)
        m = (a + c) / (2 * b);

    else if ((2 * b - a) % c == 0 && (2 * b - a) > 0)
        m = (2 * b - a) / c;


    if (m == -1)
        list.Add("NO");
    else
        list.Add("YES");

    t--;
}

foreach(var x in list)
    Console.WriteLine(x);