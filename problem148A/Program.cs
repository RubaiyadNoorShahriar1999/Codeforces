int k, l, m, n, d;
k = Convert.ToInt32(Console.ReadLine());
l = Convert.ToInt32(Console.ReadLine());
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 1; i <= d; i++) { if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0) count++; }
Console.WriteLine(count);