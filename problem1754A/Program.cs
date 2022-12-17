int t;  
t = Convert.ToInt32(Console.ReadLine());
List<string> list = new List<string>();

while (t != 0)
{
    bool isTrue = false;
    int counta = 0, countq = 0;
    int n = Convert.ToInt32(Console.ReadLine());
    string s = Console.ReadLine();

    if (s[s.Length - 1] != 'A')
        list.Add("NO");
    else
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == 'Q')
                countq++;
            else
                counta++;
            if (countq > counta)
            {
                list.Add("NO");
                isTrue = true;
                break;
            }
        }
        if (!isTrue)
            list.Add("YES");
    }
    t--;
}

foreach(string s in list)
    Console.WriteLine(s);
