List<int> list = new List<int>(5);
int min = 3;
string[] data;
data = Console.ReadLine().Split();

    for (int i = 0; i < 4; i++)
    {
        int x = Convert.ToInt32(data[i]);
        list.Add(x);     
    }
    list.Sort();
    for (int i = 0; i < 3; i++)
    {
        if (list[i] != list[i + 1])
            min--;
    }
Console.WriteLine(min);