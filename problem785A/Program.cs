int n, face = 0;
n  = Convert.ToInt32(Console.ReadLine());
string[] data = new string[n];

for(int i = 0; i < n; i++)
    data[i] = Console.ReadLine();

for (int i = 0; i < n; i++)
{
    if (data[i] == "Tetrahedron")
        face += 4;
    else if (data[i] == "Cube")
        face += 6;
    else if (data[i] == "Octahedron")
        face += 8;
    else if (data[i] == "Dodecahedron")
        face += 12;
    else if (data[i] == "Icosahedron")
        face += 20;
}

Console.WriteLine(face);