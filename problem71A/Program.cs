int n;
n = Convert.ToInt32(Console.ReadLine());

List<string> word = new List<string>();

for (int i = 0; i < n; i++)
{
    string x = Console.ReadLine();
    word.Add(x);
}

for (int i = 0; i < word.Count; i++)
{
    string p = word[i];

    if (p.Length > 10)
    {
        Console.WriteLine(p[0] + $"{p.Length - 2}" + p[p.Length - 1]);
    }
    else
    {
        Console.WriteLine(word[i]);
    }
}