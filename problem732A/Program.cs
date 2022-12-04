int k, r,count = 0;
bool isTrue = true;
string[] data;
data = Console.ReadLine().Split();
k = Convert.ToInt32(data[0]);
r = Convert.ToInt32(data[1]);

while (isTrue)
{
    count++;
    if((k * count) % 10 == 0 || (k * count) % 10 == r)
        isTrue= false;
}
Console.WriteLine(count);

