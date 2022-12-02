int n;
n = Convert.ToInt32(Console.ReadLine());
string[] data = Console.ReadLine().Split();
int points = Convert.ToInt32(data[0]); 
int min = points, max = points , amazing = 0;

while (n != 0)
{
    for(int i = 0; i < data.Length; i++)
    {
        points = Convert.ToInt32(data[i]);
    if (points < min)
    {
        min = points;
        ++amazing;
    }
    if (points > max)
    {
        max = points;
        ++amazing;
    }
    }
    n--;
}
Console.WriteLine(amazing);