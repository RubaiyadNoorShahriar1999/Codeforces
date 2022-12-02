string input;
int count = 0;

input = Console.ReadLine();

for(int i = 0; i < input.Length; i++)
{
    if (input[i] == '4' || input[i] == '7') 
        count++;
    else
        continue;
}

if(count == 4 || count == 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");