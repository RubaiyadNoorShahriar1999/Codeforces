using System.Text;

string input;
input = Console.ReadLine().ToLower();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
        continue;
    else
    {
        sb.Append('.');
        sb.Append(input[i]);
    }
}
Console.WriteLine(sb);