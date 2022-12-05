using System.Net.Http.Headers;

int[] rooms = new int[10];
int n = Convert.ToInt32(Console.ReadLine()),k =1;
string input = Console.ReadLine();

for(int i = 0; i < n; i++)  //LLRL1RL1
{
    if (input[i] == 'L')
    {
        for(int j = 0; j < n; j++)
            {
                if (rooms[j] == 0)
                {
                    rooms[j] = 1;
                    break;
                }
            }
    }

    else if (input[i] == 'R')
    {
        for (int j = 9; j >= 0; j--)
            {
                if (rooms[j] == 0)
                {
                    rooms[j] = 1;
                    break;
                }
            }
    }
    else
        rooms[input[i] -'0'] = 0;
}

for(int i = 0; i< rooms.Length; i++)
{
    Console.Write(rooms[i]);
}