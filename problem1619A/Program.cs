int t = Convert.ToInt32(Console.ReadLine());
List<string> list = new List<string>();

while (t != 0)
{
    string s;
    s = Console.ReadLine();
    bool isTrue = false;

    if (s.Length % 2 != 0)
        isTrue = false;
    else
    {
        for (int i = 0; i < s.Length / 2;)
        {
            if (s[i] == s[i + s.Length / 2])
            {
                isTrue= true;
                i++;
            }
            else
            {
                isTrue= false;
                break;
            }
        }
    }
    if(isTrue)
        list.Add("YES");
    else
        list.Add("NO");
    t--;
}
foreach(string  s in list)
{ Console.WriteLine(s); }
