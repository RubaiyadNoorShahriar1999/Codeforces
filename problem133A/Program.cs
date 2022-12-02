string input;
bool isTrue = false;
input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] >= '!' && input[i] <= '~')
    {
        if (input[i] == 'H' || input[i] == 'Q' || input[i] == '9')
            isTrue = true;
    }
}
if(isTrue)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");