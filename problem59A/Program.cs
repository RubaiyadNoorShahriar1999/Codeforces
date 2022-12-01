int countup = 0, countlow = 0;

string s;
s = Console.ReadLine();

for (int i = 0; i < s.Length; i++)
{
    char c = s[i];
    if (Char.IsUpper(c))
    {
        countup++;
    }
    else
    {
        countlow++;
    }
}
if (countup > countlow)
{
    char ch;
    for (int i = 0; i < s.Length; i++)
    {
        ch = char.ToUpper(s[i]);
        Console.Write(ch);
    }
}
else
{
    char ch;
    for (int i = 0; i < s.Length; i++)
    {
        ch = char.ToLower(s[i]);
        Console.Write(ch);
    }
}