int nob, x;

nob = Convert.ToInt32(Console.ReadLine());
while (true)
{
    x = 0;
    while (nob > 1)
    {
        if (nob % 2 == 0)
            nob = nob / 2;
        else
        {
            nob = nob - 1; x++;
        }
    }
    break;
}
Console.WriteLine(  x + 1);