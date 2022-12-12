string[] data1 = Console.ReadLine().Split();
int n = int.Parse(data1[0]);
int m = int.Parse(data1[1]);
string[] data2 = Console.ReadLine().Split();
List<int> list = new List<int>(110);

for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(data2[i]);
    list.Add(x);
}

list.Sort();
int output = 0;

for (int j = 0; j < m; j++)
{
    if (list[j] >= 0)
         break;
    
    output += list[j];
}

Console.WriteLine(-output);