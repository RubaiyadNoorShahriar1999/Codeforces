string input, base_string = "hello";
int j = 0, length = 0;

input = Console.ReadLine();

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == base_string[j])
        {
            j++; length++;
            if (length == 5)
                break;
        }
    }
    if (length == 5)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");