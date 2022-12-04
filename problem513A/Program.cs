string[] data;
data = Console.ReadLine().Split();

int n1,n2,k1,k2;
n1 = Convert.ToInt32(data[0]);
n2 = Convert.ToInt32(data[1]);
k1 = Convert.ToInt32(data[2]);
k2 = Convert.ToInt32(data[3]);

if(n1 <= n2)
    Console.WriteLine("Second");
else if(n1 > n2)
    Console.WriteLine("First");
