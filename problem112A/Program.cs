string string1, string2;

string1 = Console.ReadLine().ToLower();
string2 = Console.ReadLine().ToLower();

int sum1 = string1.Sum(b => b);
int sum2 = string2.Sum(c => c);

if (string1 == string2)
{
    Console.WriteLine(0);
}
else
{
    for (int i = 0; i < string1.Length; i++)
    {
        if (string1[i] < string2[i])
        {
            Console.WriteLine(-1);
            break;
        }

        if (string1[i] > string2[i])
        {
            Console.WriteLine(1);
            break;
        }

    }
}





