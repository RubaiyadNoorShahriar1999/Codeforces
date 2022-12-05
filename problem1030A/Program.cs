int n = Convert.ToInt32(Console.ReadLine()),count =0;
string[] data;
data = Console.ReadLine().Split();

for(int i = 0; i < n; i++)
{
    if (data[i] == "1")
        count++;
}
if(count > 0)
   Console.WriteLine("HARD");
else
    Console.WriteLine("EASY");