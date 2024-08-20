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
System.Console.WriteLine("Ingrese su nombre:");
string HeroName = Console.ReadLine();

var enemy = new Enemy();
var map = new Map(20, 20);
map.Init();

var hero = new Hero(100, 100);
bool findOut = false;
int[,] position = { { 0, 0 } };



//map[position[0,0], position[0, 1]] = Hero;
map.SetPosition(0, 0, hero.getID());


ConsoleKeyInfo cki;
Print(map.GetMap());
System.Console.WriteLine("Presione una flecha para moverse");
do
{
    cki = Console.ReadKey();
    switch (cki.Key)
    {

        case ConsoleKey.UpArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");

            //Existe una posicion position[0, 0] donde x es eje x y y es eje y. Al presionar el arrow, existe una posicion, se verifica que la posicion a la que se quiere llegar no sea pared
            if (position[0, 0] > 0 && map.getItems(position[0, 0] - 1, position[0, 1]) != "L") // Verificamos que no se este pegando a un limite o que el siguiente elemento hacia Arriba sea una pared
            {
                Actions.EvalActions(hero, map, position, -1, "x", enemy);
                position[0, 0] -= 1;
            }
            map.SetPosition(position[0, 0], position[0, 1], hero.getID());
            Print(map.GetMap());

            break;


        case ConsoleKey.DownArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 0] < map.N - 1 && map.getItems(position[0, 0] + 1, position[0, 1]) != "L")
            {
                Actions.EvalActions(hero, map, position, +1, "x", enemy);
                position[0, 0] += 1;
            }


            map.SetPosition(position[0, 0], position[0, 1], hero.getID());


            Print(map.GetMap());
            break;
        case ConsoleKey.RightArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 1] < map.M - 1 && map.getItems(position[0, 0], position[0, 1] + 1) != "L")
            {
                Actions.EvalActions(hero, map, position, +1, "y", enemy);
                position[0, 1] += 1;
            }

            map.SetPosition(position[0, 0], position[0, 1], hero.getID());


            Print(map.GetMap());

            break;
        case ConsoleKey.LeftArrow:
            //map.SetPosition(position[0, 0], position[0, 1], "X");
            if (position[0, 1] > 0 && map.getItems(position[0, 0], position[0, 1] - 1) != "L")
            {
                Actions.EvalActions(hero, map, position, -1, "y", enemy);
                position[0, 1] -= 1;
            }


            map.SetPosition(position[0, 0], position[0, 1], hero.getID());


            Print(map.GetMap());
            break;
    }
    //System.Console.WriteLine(map.FindOut());
    // System.Console.WriteLine(map.getItems(position[0, 0], position[0, 1]));
    System.Console.WriteLine($"¸,ø¤º°`°º¤ø,¸¸,ø¤º° {HeroName} °º¤ø,¸¸,ø¤º°`°º¤ø,¸\n");
    System.Console.Write($"Health: {hero.GetHealth()} | Attack: {hero.GetAttack()} | ");
    Console.Write("Posiones: ");
    if (hero.GetPoisons() == 0)
    {
        Console.Write("No posiones");

    }
    else
    {
        Console.Write(hero.GetPoisons());

    }

    System.Console.WriteLine();

    /*foreach (KeyValuePair<string, bool> item in hero.Items)
    {
        System.Console.WriteLine($"{item.Key}:{item.Value}");
    }*/
    findOut = map.FindOut();

    if (hero.GetHealth() <= 0)
    {
        Console.Clear();
        System.Console.WriteLine("Y O U  D I E D");
    }

    if (findOut)
    {
        Console.Clear();
        System.Console.WriteLine("Encontraste la salida");
    }

} while (cki.Key != ConsoleKey.Escape && !findOut && hero.GetHealth() > 0);



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