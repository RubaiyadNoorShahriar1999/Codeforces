int t;
t = Convert.ToInt32(Console.ReadLine());
List<char> list = new List<char>();

while (t != 0)
{
    string b;
    b = Console.ReadLine();

    list.Add(b[0]);
    for (int i = 1; i < b.Length; i+=2)
        list.Add(b[i]);

    list.Add('\n');
    t--;
}

foreach(char c in list)
{ Console.Write(c); }