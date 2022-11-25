int test_cases, i;
test_cases = Convert.ToInt32(Console.ReadLine());

int var1, var2;
for(i = 0; i < test_cases; i++)
{
    string[] data = Console.ReadLine().Split();
    var1 = Convert.ToInt32(data[0]);
    var2 = Convert.ToInt32(data[1]);

        if (var1 % var2 == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int w = var1 % var2;
            Console.WriteLine( var2 - w + "\t");
        }

}