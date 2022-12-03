using System.Diagnostics.Metrics;

int n = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for (int i = 0; i < n; i++)
{
    string[] data1 = new string[2];
    data1 = Console.ReadLine().Split();
    int[,] x = new int[n, 2];
    for (int j = 0; j < 2; j++)
    {
        x[i, j] = Convert.ToInt32(data1[j]);
    }
    for (int k = 0; k < 1; k++)
    {
        if (x[i, k+1] - x[i, k] >= 2)
        {
            counter++;
        }
    }
}
Console.WriteLine(counter);