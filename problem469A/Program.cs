int n, p, q, count1 = 1, counter2 = 0;
List<int> list = new List<int>(1000);
n = Convert.ToInt32(Console.ReadLine());

string[] data1;
string[] data2;
data1 = Console.ReadLine().Split();
data2 = Console.ReadLine().Split();
p = Convert.ToInt32(data1[0]);
q = Convert.ToInt32(data2[0]);

for (int i = 0; i < p; i++)
{
    list.Add(Convert.ToInt32(data1[i + 1]));
}

for (int i = p; i < p + q; i++)
{
    list.Add(Convert.ToInt32(data2[count1++]));
}

list.Distinct();
list.Sort();
list.Reverse();

for (int j = 1; j <= n; j++)
    for (int i = 0; i < (p + q); i++)
    {
        if (j == list[i]) { counter2++; break; }
    }

if (counter2 == n) 
    Console.WriteLine("I become the guy.");
else 
    Console.WriteLine("Oh, my keyboard!");
