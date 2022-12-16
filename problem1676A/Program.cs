int t = Convert.ToInt32(Console.ReadLine());
List<string> list = new List<string>();

while (t != 0)
{
    string lottery = Console.ReadLine();
    int p = 0, q = 0;
    int x = 0, y = 0;

    for (int i = 0; i <= 2; i++)
    {
        p = lottery[i] - '0';
        x += p;
    }

    for (int j = 3; j < 6; j++)
    {
        q = lottery[j] - '0';
        y += q;
    }

    if (x == y)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
    t--;
}

//foreach (string s in list)
//    Console.WriteLine(s);