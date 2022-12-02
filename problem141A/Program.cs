string guest, residence_host, combined, pile;
bool isTrue = false;

guest = Console.ReadLine();
residence_host = Console.ReadLine();
pile = Console.ReadLine();
combined = guest + residence_host;

char[] x = combined.ToCharArray();
Array.Sort(x);
char[] y = pile.ToCharArray();
Array.Sort(y);

if(x.Length== y.Length)
{
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == y[i])
            isTrue = true;
        else
        {
            isTrue = false;
            break;
        }
    }
}
else
    isTrue = false;

if (isTrue)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");