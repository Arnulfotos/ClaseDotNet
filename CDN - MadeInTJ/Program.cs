using System.Diagnostics;
using CDN___MadeInTJ;

// Arma -> incrementan AP, Armadura -> Aumenta HP, Casco -> Aumenta HP, Posion -> Aumenta HP

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
Console.Clear();
var map = new Map(20, 20);
map.Init();


var hero = new Hero(100, 100);
bool findOut = false;
int[,] position = { { 0, 0 } };



//map[position[0,0], position[0, 1]] = Hero;
map.SetPosition(0, 0, hero.getID());


ConsoleKeyInfo cki;
Print(map.GetMap());

do
{
    cki = Console.ReadKey();
    switch (cki.Key)
    {

        case ConsoleKey.UpArrow:

            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 0] > 0 && map.getItems(position[0, 0] - 1, position[0, 1]) != "L")
            {
                string Up = map.getItems(position[0, 0] - 1, position[0, 1]);
                if (Up == "W")
                {
                    hero.setAttack(10);
                    hero.Items["W"] = true;
                }
                if (Up == "A" || Up == "H")
                {
                    hero.setHealth(10, Up);
                    hero.Items[Up] = true;
                }
                if (Up == "P")
                {
                    hero.AddPoison();
                }
                if (Up == "E")
                {
                    do
                    {
                        Console.Clear();


                        System.Console.WriteLine("C VS E");


                        System.Console.WriteLine("1. Atacar | 2. Posion | 3. Huir");
                        int Eleccion = int.Parse(Console.ReadLine());

                        switch (Eleccion)
                        {
                            case 1:
                                System.Console.WriteLine("PUtazos");
                                break;
                            case 3:
                                hero.SetAction("Huir");
                                break;
                        }
                        System.Console.WriteLine(hero.GetAction());
                        Task.Delay(2000).Wait();
                    } while (hero.GetAction() != "Huir" && hero.GetHealth() != 0);
                    position[0, 0] += 1;
                }

                position[0, 0] -= 1;


            }


            map.SetPosition(position[0, 0], position[0, 1], hero.getID());

            Print(map.GetMap());

            break;
        case ConsoleKey.DownArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 0] < map.N - 1 && map.getItems(position[0, 0] + 1, position[0, 1]) != "L")
            {
                string Down = map.getItems(position[0, 0] + 1, position[0, 1]);
                if (Down == "W")
                {
                    hero.setAttack(10);
                    hero.Items["W"] = true;
                }
                if (Down == "A" || Down == "H")
                {
                    hero.setHealth(10, Down);
                    hero.Items[Down] = true;
                }
                if (Down == "P")
                {
                    hero.AddPoison();
                }
                position[0, 0] += 1;
            }


            map.SetPosition(position[0, 0], position[0, 1], hero.getID());


            Print(map.GetMap());
            break;
        case ConsoleKey.RightArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 1] < map.M - 1 && map.getItems(position[0, 0], position[0, 1] + 1) != "L")
            {
                string Rigth = map.getItems(position[0, 0], position[0, 1] + 1);
                if (Rigth == "W")
                {
                    hero.setAttack(10);
                    hero.Items["W"] = true;
                }
                if (Rigth == "A" || Rigth == "H")
                {
                    hero.setHealth(10, Rigth);
                    hero.Items[Rigth] = true;
                }
                if (Rigth == "P")
                {
                    hero.AddPoison();
                }
                position[0, 1] += 1;
            }

            map.SetPosition(position[0, 0], position[0, 1], hero.getID());


            Print(map.GetMap());
            break;
        case ConsoleKey.LeftArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 1] > 0 && map.getItems(position[0, 0], position[0, 1] - 1) != "L")
            {
                string Left = map.getItems(position[0, 0], position[0, 1] - 1);
                if (Left == "W")
                {
                    hero.setAttack(10);
                    hero.Items["W"] = true;
                }
                if (Left == "A" || Left == "H")
                {
                    hero.setHealth(10, Left);
                    hero.Items[Left] = true;
                }
                if (Left == "P")
                {
                    hero.AddPoison();
                }
                position[0, 1] -= 1;
            }


            map.SetPosition(position[0, 0], position[0, 1], hero.getID());


            Print(map.GetMap());
            break;
    }
    //System.Console.WriteLine(map.FindOut());
    // System.Console.WriteLine(map.getItems(position[0, 0], position[0, 1]));

    System.Console.Write($"Health: {hero.GetHealth()} | Attack: {hero.GetAttack()} | ");
    Console.Write("Posiones: ");
    if (hero.GetPoisons() == 0)
    {
        Console.Write("No posiones");

    }
    else
    {
        for (int i = 1; i <= hero.GetPoisons(); i++)
        {


            Console.Write("•");


        }
    }

    System.Console.WriteLine();

    foreach (KeyValuePair<string, bool> item in hero.Items)
    {
        System.Console.WriteLine($"{item.Key}:{item.Value}");
    }
    findOut = map.FindOut();

} while (cki.Key != ConsoleKey.Escape && !findOut);

System.Console.WriteLine("Encontraste la salida");

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