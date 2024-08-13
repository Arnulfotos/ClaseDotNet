using CDN___MadeInTJ;

/*string[,] map = { { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
                  { "X", "X", "X", "X", "X", "X", "X", "X","X","X" },
};*/

var map = new Map(16, 16);
map.Init();

string Hero = "C";

int[,] position = { { 0, 0, } };

//map[position[0,0], position[0, 1]] = Hero;
map.SetPosition(0, 0, Hero);



ConsoleKeyInfo cki;
Print(map.GetMap());

do
{
    cki = Console.ReadKey();
    switch(cki.Key)
    {

        case ConsoleKey.UpArrow:
            map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 0] > 0)
            {
                position[0, 0] -= 1;
            }
            map.SetPosition(position[0,0], position[0, 1], Hero);
            Print(map.GetMap());
            
            break;
        case ConsoleKey.DownArrow:
            map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 0] < map.N - 1)
            {
                position[0, 0] += 1;
            }
            map.SetPosition(position[0, 0], position[0, 1], Hero);
            Print(map.GetMap());
            break;
        case ConsoleKey.RightArrow:
            map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 1] < map.M - 1)
            {
                position[0, 1] += 1;
            }
            map.SetPosition(position[0, 0], position[0, 1], Hero);
            Print(map.GetMap());
            break;
        case ConsoleKey.LeftArrow:
            map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 1] > 0)
            {
                position[0, 1] -= 1;
            }
            map.SetPosition(position[0, 0], position[0, 1], Hero);
            Print(map.GetMap());
            break;
    }



} while (cki.Key != ConsoleKey.Escape);

//Print(map);
void Print(string[,] array)
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}