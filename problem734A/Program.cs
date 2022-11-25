int n, anton = 0, danik = 0;
char ch;

n = Convert.ToInt32(Console.ReadLine());
char[] charlist = new char[n];

for (int i = 0; i < n; i++)
{
    ch = (char)Console.Read();
    charlist[i] = ch;
}

for (int i = 0; i < n; i++)
{ 
    if (charlist[i] == 'A')
        anton = anton + 1;
    else
        danik = danik + 1;
}

if (anton > danik)
   Console.WriteLine("Anton");
else if (danik > anton)
   Console.WriteLine("Danik");
else
   Console.WriteLine("Friendship");
