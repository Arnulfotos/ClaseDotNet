using CDN___MadeInTJ;

public static class Actions
{


    public static void EvalActions(Hero hero, Map map, int[,] position, int move, string axis, Enemy enemy)
    {
        string nextMov;

        if (axis == "x")
        {
            nextMov = map.getItems(position[0, 0] + move, position[0, 1]); // Guardamos esa next position para poder saber que hacer con ella

        }
        else
        {
            nextMov = map.getItems(position[0, 0], position[0, 1] + move); // Guardamos esa next position para poder saber que hacer con ella

        }
        if (nextMov == "W") // Si esta next position es un arma
        {
            if (!hero.Items["W"]) // Y esta arma no ha sido equipada
            {
                System.Console.WriteLine("Deseas el item? Y/n"); // Le solicitamos una decision al cleinte
                string? decision = Console.ReadLine();
                if (decision!.ToLower() == "y") // Si decidio tomarla
                {
                    hero.setAttack(Items.GetWeapon()); // Se agrega el Attack
                    hero.Items["W"] = true; // Se pone en inventario que el item fue equipado
                }
            }

        }
        if (nextMov == "A") // Si next position es una Armor
        {
            if (!hero.Items["A"]) // y no ha sido equipada
            {
                System.Console.WriteLine("Deseas el item? Y/n"); //Le solicitamos una decision al cleinte
                string? decision = Console.ReadLine();
                if (decision!.ToLower() == "y") // Si decidio tomarla
                {
                    hero.setHealth(Items.GetArmor(), nextMov); // Se agrega el Healt y el Elemento por el cual fue agregado -> dentro de esta funcion, no se agrega el health si ya fue equipado el armor
                    hero.Items[nextMov] = true; // Se pone en inventario que el item fue equipado
                }
            }
        }
        if (nextMov == "H") // Lo mismo que Armor
        {
            if (!hero.Items["H"])
            {
                System.Console.WriteLine("Deseas el item? Y/n");
                string? decision = Console.ReadLine();
                if (decision!.ToLower() == "y")
                {
                    hero.setHealth(Items.GetHelmet(), nextMov);
                    hero.Items[nextMov] = true;
                }
            }
        }
        if (nextMov == "P")
        {
            if (hero.GetPoisons() < 5)
            {
                System.Console.WriteLine("Deseas el item? Y/n");
                string? decision = Console.ReadLine();
                if (decision!.ToLower() == "y")
                {
                    hero.AddPoison();
                }
            }
        }
        if (nextMov == "E")
        {

            do
            {

                Console.Clear();
                hero.ClearAction();
                System.Console.WriteLine("C VS E\n");
                System.Console.WriteLine("1. Atacar | 2. Posion | 3. Huir\n");
                System.Console.Write($"C - Health: {hero.GetHealth()} | Attack: {hero.GetAttack()} | ");


                Console.Write("Posiones: ");
                if (hero.GetPoisons() == 0)
                {
                    Console.Write("No posiones");
                }
                else
                {
                    Console.Write(hero.GetPoisons());
                }
                Console.WriteLine();
                System.Console.Write($"E - Health: {enemy.GetHealth()} | Attack: {enemy.GetAttack()}\n");
                int Eleccion = int.Parse(Console.ReadLine());

                switch (Eleccion)
                {
                    case 1:
                        hero.ReciveAttack(enemy.GetAttack());
                        enemy.setHealth(hero.GetAttack());
                        System.Console.WriteLine("G E T  W R E C K E D  N 0 0 B");
                        if (enemy.GetHealth() <= 0)
                        {
                            System.Console.WriteLine("Enemigo pulverizado");
                            if (axis == "x")
                            {
                                // Guardamos esa next position para poder saber que hacer con ella
                                map.RemoveElement(position[0, 0] + move, position[0, 1]);
                            }
                            else
                            {
                                map.RemoveElement(position[0, 0], position[0, 1] + move); // Guardamos esa next position para poder saber que hacer con ella

                            }

                        }
                        break;
                    case 2:
                        hero.UsePoison(Items.GetPosion());
                        hero.ReciveAttack(enemy.GetAttack());
                        break;
                    case 3:
                        hero.SetAction("Huir");
                        break;
                }
                System.Console.WriteLine(hero.GetAction());

                Task.Delay(2000).Wait();
            } while (hero.GetAction() != "Huir" && hero.GetHealth() > 0 && enemy.GetHealth() > 0);
            if (axis == "x")
            {
                position[0, 0] += -move;
            }
            else
            {
                position[0, 1] += -move;
            }
        }
    }
}