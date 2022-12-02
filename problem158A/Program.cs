int n, k, input, count = 0;
List<int> marks = new List<int>();
string[] data1 = Console.ReadLine().Split();

n = Convert.ToInt32(data1[0]);
k = Convert.ToInt32(data1[1]);

string[] data2 = Console.ReadLine().Split();

    for (int i = 0; i < n; i++)
    {
        input = Convert.ToInt32(data2[i]);
        marks.Add(input);
    }
    for (int j = 0; j < n; j++)
    {
        if (marks[j] >= marks[k-1] && marks[j] > 0)
        {
            count++;
        }
    }
Console.WriteLine(count);