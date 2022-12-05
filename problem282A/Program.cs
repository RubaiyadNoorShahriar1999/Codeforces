int n = Convert.ToInt32(Console.ReadLine()), x = 0;

for (int i = 0; i < n; i++)
{
    string s;
    s = Console.ReadLine();
    for (int j = 0; j < s.Length; j += 2)
    {
        if (s[j] == '+')
        {
            x++;
            break;
        }
        else if (s[j] == '-')
        {
            x--;
            break;
        }
    }
}

Console.WriteLine(x);