using System.Diagnostics.Metrics;

int n, counter1 = 0, counter2 = 0;
n = Convert.ToInt32(Console.ReadLine());
int[,] x = new int[n, 2];

for (int i = 0; i < n; i++)
{
    string[] data1 = new string[2];
    data1 = Console.ReadLine().Split();

    for (int j = 0; j < 2; j++)
        x[i, j] = Convert.ToInt32(data1[j]);

    for (int k = 0; k < 1; k++)
    {
        if (x[i, k] > x[i, k + 1])
            counter1++;
        else if (x[i, k] < x[i, k + 1])
            counter2++;
    }
}

if (counter1 < counter2)
    Console.WriteLine("Chris");
else if(counter1 > counter2)
    Console.WriteLine("Mishka");
else
    Console.WriteLine("Friendship is magic!^^");

