int n = Convert.ToInt32(Console.ReadLine());
List<int> list = new List<int>();
string[] data = Console.ReadLine().Split();

for(int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(data[i]);
    list.Add(x);
}

list.Sort();
for (int i = 0; i < n; i++)
    Console.Write(list[i] + " ");
