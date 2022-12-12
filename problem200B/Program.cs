List<int> list = new List<int>(110);
int n = Convert.ToInt32(Console.ReadLine());
string[] data = Console.ReadLine().Split();
int total = 0;

for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(data[i]);
    total += x;
}
Console.WriteLine(Convert.ToDouble(total) / n);
