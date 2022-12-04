int a, b, i;
string[] data;
data = Console.ReadLine().Split();

a = Convert.ToInt32(data[0]);
b = Convert.ToInt32(data[1]);

for(i = 1; i<10; i++)
{
    a = a * 3;
    b = b * 2;

    if (a > b)
        break;
}
Console.WriteLine(i);