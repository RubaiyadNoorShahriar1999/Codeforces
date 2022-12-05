int n = Convert.ToInt32(Console.ReadLine());
string s = Console.ReadLine().ToUpper();
int[] arr = new int[26];
bool flag = true;

for(int j = 0; j < n ; j++)  
{
    int x = Convert.ToChar(s[j]) - 65;
    arr[x]++;
}

for(int i =0; i < 26; i++)
{
    if (arr[i] == 0)
        flag = false;
}

if(flag)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");