using System.Diagnostics.Metrics;

int n,counter1 = 0;
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] data1 = new string[3];
    data1 = Console.ReadLine().Split();
    int[,] x = new int[n,3];
    for (int j = 0; j < 3; j++)
    {
        x[i,j] = Convert.ToInt32(data1[j]);
    }
    int counter2 = 0;
    for (int k = 0; k < 3; k++)
    {
        if (x[i,k] == 1)
        {
            counter2++;
        }
    }
    if(counter2 >= 2)
    {
        counter1++;
    }
}
Console.WriteLine(counter1);