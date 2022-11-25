List<int> encrypted = new List<int>();

string input = Console.ReadLine();
string[] data = input.Split(" "); 

foreach(var d in data)
{
    encrypted.Add(Convert.ToInt32(d)); 
}

encrypted.Sort();
for (int i = 0; i < 3; i++)
    Console.WriteLine(encrypted[3] - encrypted[i] + " "); 
