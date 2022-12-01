int count = 0;
string input1; 
string input2;
input1 = Console.ReadLine();
input2 = Console.ReadLine();
char[] a = input1.ToCharArray().Reverse().ToArray();

for(int i = 0; i < a.Length; i++)
{
    if (a[i].Equals(input2[i]))
        count++;
    else
        break;
}

if(count == input1.Length)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");