int t;
t = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    int n;
    n = Convert.ToInt32(Console.ReadLine());

    if( n % 2 == 0)
    {
        Console.WriteLine((n / 2) - 1);
    }
    else
    {
        Console.WriteLine(n/2);
    }
}

