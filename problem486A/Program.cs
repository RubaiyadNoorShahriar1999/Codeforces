decimal n, a;
n = Convert.ToInt64(Console.ReadLine());

if (n % 2l == 0l) 
    a = n / 2l;
else 
    a = ((n + 1l) / 2l) * (-1l);
Console.WriteLine(a);