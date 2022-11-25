/*int a, count = 0;
a = Convert.ToInt32(Console.ReadLine());

int[] x = new int[a];
int[] y = new int[a];
int[] backup = new int[a];

for (int i = 0; i < a; i++)
{
    x[i] = Convert.ToInt32(Console.Read());
    y[i] = Convert.ToInt32(Console.ReadLine());
}

*//*for (int i = 0; i < a; i++)
{
    Console.WriteLine(x[i]);
    Console.WriteLine(y[i]);
}
*//*

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (x[i] == y[j])
        {
            count++;
        }
    }
}

Console.WriteLine(count);*/

var a = 0;
var counts = 0;
a = Convert.ToInt32(Console.ReadLine());
int[] x = new int[a];
int[] y = new int[a];

for (int i = 0; i < a; i++)
{
    x[i] = Convert.ToInt32(Console.Read());
    y[i] = Convert.ToInt32(Console.Read());
}

for (int i = 0; i < a; i++)
{
    Console.Write(x[i] + " ");
    Console.WriteLine(y[i]);
}
Console.WriteLine(a);


for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (x[i] == y[j])
        {
            counts++;
        }
    }
}

Console.WriteLine(counts);