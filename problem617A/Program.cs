int coordinate, steps;

coordinate = Convert.ToInt32(Console.ReadLine());
steps = coordinate / 5;

if (coordinate % 5 > 0)
    steps++;

Console.WriteLine(steps);