using System;
int num = 0,pass = 1; 
string input;
input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (input[i] == input[j])
        {
            num++;
        }
    }
    if (num == 0)
    {
        pass++;
    }
    num = 0;
}

if (pass % 2 == 0)
    Console.WriteLine("IGNORE HIM!");
else
    Console.WriteLine("CHAT WITH HER!");
