using System;
using System.Collections.Generic;

List<char> nums = new List<char>(); 

for (int i = 0; i < 1000; i++)
{
    char input = (char)Console.Read(); 
    if (input == '}')
    {
        break;
    }
    else
    {
        nums.Add(input);
    }
}
int counter = 0;
List<char> myList = nums.Distinct().ToList();

for (int i = 0; i < myList.Count; i++)
{
    if (myList[i] != '{' && myList[i] != '}' && myList[i] != ' ' && myList[i] != ',')
    {
        counter++;
    }
}
Console.Write(counter);