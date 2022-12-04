List<int> list1 = new List<int> {};
List<int> list2 = new List<int> {};
int output = 0, n;
n = Convert.ToInt32(Console.ReadLine());
string[] data;
data = Console.ReadLine().Split();
int[] x = new int[data.Length];

for(int i = 0; i < data.Length; i++)
{
    int input = Convert.ToInt32(data[i]);
    list1.Add(input);
    list2.Add(input);
}

list2.Sort();
list2.Reverse();
list1.Sort();

for(int i = 0; i < data.Length; i++)
{
    x[i] = list2[0] - list1[i];
}
/*for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine(list2[0]);
}*/

for (int i = 0; i < x.Length; i++)
{
    output += x[i];
}

Console.WriteLine(output);