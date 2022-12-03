int _i = 0, _j = 0;

for (int i = 1; i <= 5; i++)
{
    string[] input = Console.ReadLine().Split();
    for (int k = 1; k <= 5; k++)
    {
        int data = Convert.ToInt32(input[k - 1]);
        if (data == 1)
        {
            _i = i;
            _j = k;
        }
    }
}
Console.WriteLine(Math.Abs(_i - 3) + Math.Abs(_j - 3));

