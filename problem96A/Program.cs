int count0 = 1, count1 = 1;
string list;
list = Console.ReadLine();

for(int i = 0; i < list.Length; i++)
{
    if (i == list.Length - 1)
    {
        break;
    }
    else
    {
        if (list[i] == list[i + 1]) 
            {
                if (list[i] == '0')
                    count0++;
                else 
                    count1++;
            }
        else
            {
                if (list[i] == '0' && count0 < 7)
                    count0 = 1;
                else if (list[i] == '1' && count1 < 7)
                    count1 = 1; 
            }
    }
}

if (count0 >= 7 || count1 >= 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
