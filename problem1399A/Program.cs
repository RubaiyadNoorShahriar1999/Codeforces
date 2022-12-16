int t = Convert.ToInt32(Console.ReadLine());
List<string> list1 = new List<string>();
while(t != 0)
{
    int n = Convert.ToInt32(Console.ReadLine());
    List<int> list2 = new List<int>();
    string[] data = Console.ReadLine().Split();

    for(int i = 0; i < n; i++)
        list2.Add(Convert.ToInt32(data[i]));

    list2.Sort();
    bool isTrue = true; 
    for(int i = 0; i< n-1;i++)
    {
        if (list2[i + 1] - list2[i] > 1)
            isTrue= false;
    }
    if (isTrue)
        list1.Add("YES");
    else
        list1.Add("NO");
    t--;
}

foreach(string s in list1)
{ Console.WriteLine(s); }