int count = 0;

int amount = Convert.ToInt32(Console.ReadLine());

while (amount <= 1000000000)
{
    if (amount >= 100)
    {
        count++; 
        amount = amount - 100; 
    }
    else if (amount >= 20) 
    { 
        count++; 
        amount = amount - 20;
    }
    else if (amount >= 10) 
    { 
        count++;
        amount = amount - 10;
    }
    else if (amount >= 5) 
    { 
        count++; 
        amount = amount - 5; 
    }
    else if(amount >= 1)
    { 
        count++; 
        amount = amount - 1;
    }
    else
    {
        break;
    }
}
Console.WriteLine(count);
