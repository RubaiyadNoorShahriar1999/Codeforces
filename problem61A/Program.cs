using System.Text;

string s1, s2;
s1 = Console.ReadLine();
s2 = Console.ReadLine();

StringBuilder sb = new StringBuilder(s1);

for (int i = 0; i < s1.Length; ++i)
{
    if (s1[i] == s2[i])
    {
        sb[i] = '0';
    }
    else
    {
        sb[i] = '1';
    }
}
Console.WriteLine(sb);