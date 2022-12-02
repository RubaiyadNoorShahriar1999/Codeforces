int n;
n = Convert.ToInt32(Console.ReadLine());

List<string> team = new List<string>();
List<string> team_distinct = new List<string>();

for (int i = 0; i < n; i++)
{
    string x = Console.ReadLine();
    team.Add(x);
}

team_distinct.AddRange(team.Distinct());
int count1 = 0, count2 = 0;

 for(int j = 0; j < team.Count; j++)
        {
            if (team_distinct[0] == team[j])
            {
                count1++;
            }
            else
            {
                count2++;
            }
        }

if (team.Count == 1)
{
    Console.WriteLine(team[0]);
}
else
{
    if (count1 > count2)
    {
        Console.WriteLine(team_distinct[0]);
    }
    else
    {
        Console.WriteLine(team_distinct[1]);
    }
}
