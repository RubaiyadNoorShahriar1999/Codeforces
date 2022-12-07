int N, n;
bool flag = true;
n = Convert.ToInt32(Console.ReadLine());
N = n;
if (n <= 10 && n % 4 != 0)
{
    if (n < 4)
        Console.WriteLine(4);
    else if (n < 8)
        Console.WriteLine(8);
    else
        Console.WriteLine(13);
    flag = false;
}

if (flag)
{
    while (true)
    {
        int sum = 0;
        while (n >= 10)
        {
            sum += n % 10;
            n /= 10;

            if (n < 10)
                sum += n;
        }

        if (sum % 4 == 0)
        {
            Console.WriteLine(N);
            break;
        }
        else
        {
            N++;
            n = N;
        }
    }
}