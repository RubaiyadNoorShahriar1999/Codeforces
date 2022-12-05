int n = Convert.ToInt32(Console.ReadLine());
int[] array= new int[200];
string[] data;
data = Console.ReadLine().Split();

for (int i = 1;i <=n; i++)
{
    int x = Convert.ToInt32(data[i-1]);
    array[x] = i;
}

for (int i = 1; i <= array.Length-1; i++)
{
    if (array[i] != 0)
        Console.Write(array[i] + " ");
}
