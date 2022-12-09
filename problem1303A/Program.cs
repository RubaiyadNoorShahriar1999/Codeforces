List<int> list = new List<int>();
int t;
t = Convert.ToInt32(Console.ReadLine());
string s; char a = '0';

while (t != 0)
{
    int count = 0; int pos1 = 0; int pos2 = 0;
    s = Console.ReadLine();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '1')
        {
            pos1 = i;
            break;
        }
    }
    for (int j = s.Length - 1; j > pos1; j--)
    {
        if (s[j] == '1')
        {
            pos2 = j;
            break;
        }
    }
    for (int k = pos1; k < pos2; k++)
    {
        if (s[k] == '0')
            count++;
        else
            a += '1';
    }
    list.Add(count);
    t--;
}

foreach (var x in list)
    Console.WriteLine(x); 
