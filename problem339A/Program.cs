int count = 0;
List<int> arr = new List<int>(100);

string[] data;
data = Console.ReadLine().Split("+");

for (int i = 0; i < data.Length; i++)
{
    if (Convert.ToChar(data[i]) == '+')
    {
        continue;
    }
    else
    { 
        arr.Add(Convert.ToInt32(data[i]));
    }
}

arr.Sort();
for (int i = 0; i < arr.Count; i++)
{
    Console.Write(Convert.ToInt32(arr[i]));
    if (i == arr.Count - 1)
    {
        break;
    }
    Console.Write("+");
}