long n, m, a, x, y, sum = 0;
string[] data;

data = Console.ReadLine().Split();
n = Convert.ToInt32(data[0]);
m = Convert.ToInt32(data[1]);
a = Convert.ToInt32(data[2]);

    x = n / a;
    y = m / a;

    if (n % a != 0)
        x = x + 1;
    if (m % a != 0)
        y = y + 1;

    sum = x * y;
Console.WriteLine(sum);