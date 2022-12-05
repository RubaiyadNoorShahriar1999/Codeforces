int n, h, width = 0;
string[] data1, data2;
List<int> list = new List<int>();
data1 = Console.ReadLine().Split();
n = Convert.ToInt32(data1[0]);
h = Convert.ToInt32(data1[1]);

data2 = Console.ReadLine().Split();
for(int i = 0; i < data2.Length; i++)
{
    int x = Convert.ToInt32(data2[i]);
    list.Add(x);
}

for(int j = 0 ; j < n; j++)
{
    if (list[j] > h)
        width += 2;
    else if (list[j] <= h)
        width+= 1;
}
Console.WriteLine(width);

