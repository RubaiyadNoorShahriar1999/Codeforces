using System.Text;

string input = Console.ReadLine();
StringBuilder sb = new StringBuilder(input);
string x  = input.ToUpper();
sb[0] = x[0];
Console.WriteLine(sb);