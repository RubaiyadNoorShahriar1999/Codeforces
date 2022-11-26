int no_of_soilders;
int[] a = new int[100];
no_of_soilders = Convert.ToInt32(Console.ReadLine());

string[] data = Console.ReadLine().Split();
for(int i = 0; i < no_of_soilders; i++)
{
    a[i]= Convert.ToInt32(data[i]); 
}
int mina = a[0], maxa = a[0], mini = 0, maxi = 0;

for (int i = 1; i < no_of_soilders; ++i)
{
    if (a[i] > maxa)
    {
        maxa = a[i];
        maxi = i;
    }
    if (a[i] <= mina)
    {
        mina = a[i];
        mini = i;
    }
}
int result = maxi + (no_of_soilders - 1 - mini) - (mini < maxi ? 1 : 0);
Console.WriteLine(result);