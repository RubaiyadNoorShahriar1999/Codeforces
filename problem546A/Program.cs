string[] data;
data = Console.ReadLine().Split();
int n, t, k, w;
long sum = 0;
k = Convert.ToInt32(data[0]);
n = Convert.ToInt32(data[1]);
w = Convert.ToInt32(data[2]);

for (int i = 1; i <= w; i++)
     sum = sum + (i * k);

if (sum <= n)
    Console.WriteLine(0);
else 
    Console.WriteLine(sum - n);