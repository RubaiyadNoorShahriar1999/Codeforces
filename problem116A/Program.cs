int n, a, b, sum = 0, k = 0;
n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split();
    a = Convert.ToInt32(data[0]);
    b = Convert.ToInt32(data[1]);

    sum = (a + k) - b;
    if (sum < 0) k = 0;
    else k = sum;
}
Console.WriteLine(sum);