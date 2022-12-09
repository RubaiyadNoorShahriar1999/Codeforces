int t;
t = Convert.ToInt32(Console.ReadLine());
List<int> list = new List<int>();
while(t != 0)
{ 
    int  a,b,x,y;
    string[] data = Console.ReadLine().Split();

    int ans = 0;
    a = Convert.ToInt32(data[0]);
    b = Convert.ToInt32(data[1]);
    x = Convert.ToInt32(data[2]);
    y = Convert.ToInt32(data[3]);

    ans = (b - a) / (x + y);
    int tmp = (b - a) % (x + y);

    if (tmp != 0) 
        list.Add(-1);
    else 
        list.Add(ans);
    t--;
}

foreach(int i in list)
    Console.WriteLine(i); 