int a, b, c;
int[] ans = new int[10];
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

ans[0] = a + (b * c);
ans[1] = a * (b + c);
ans[3] = a * b * c;
ans[4] = (a + b) * c;
ans[5] = (a * b) + c;
ans[6] = a + b + c;
int max = ans[0];

max = ans.Max();

/*for(int i = 0; i < 10; i++)
{
    if(max >= ans[i])
    { max = ans[i]; }
    else
    { max = max; }
}*/

Console.WriteLine(max);