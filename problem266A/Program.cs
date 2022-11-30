string b;
int a, c = 0;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToString(Console.ReadLine()+ " ");

for (int i = 0; i < a; i++)
{
    if (b[i] == b[i + 1])
    {
        c++;
    }
}
Console.WriteLine(c);