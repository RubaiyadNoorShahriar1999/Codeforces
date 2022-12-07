int a, b, c, d;
string[] data = Console.ReadLine().Split();
a = Convert.ToInt32(data[0]);
b = Convert.ToInt32(data[1]);
c = Convert.ToInt32(data[2]);
d = Convert.ToInt32(data[3]);


if (a + b == c + d || a + c == b + d || a + d == b + c || a + b + c == d || a + c + d == b || a + b + d == c || b + c + d == a)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
