int n, x, even =0, lastodd = 0, lasteven =0;
string[] data;

n = Convert.ToInt32(Console.ReadLine());
data = Console.ReadLine().Split();

for (int i = 0; i < n; i++)
{
    x = Convert.ToInt32(data[i]);
    if (x % 2 == 0) { even += 1; lasteven = i+1; }
    else { even -= 1; lastodd = i+1; }
}

int output =(even > 0 ? lastodd : lasteven);
Console.WriteLine(output);
