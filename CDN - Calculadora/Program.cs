Console.WriteLine("Bienvenido a my beautiful calculator");



ConsoleKeyInfo ck;

do
{
    Console.WriteLine("Seleccione la operacion a realizar:\n" +
        " [1] Sumar\n [2] Restar\n [3] Multiplicar\n [4] Dividir\n"
        );


    int seleccion = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Ingrese el primer numero");
    int num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese el segundo numero");
    int num2 = int.Parse(Console.ReadLine()!);

    switch (seleccion)
    {
        case 1:
            Console.WriteLine($"\nEl resultado es {Suma(num1, num2)}"); 
                break;

        case 2:
            Console.WriteLine($"\nEl resultado es {Resta(num1, num2)}"); 
                break;
        case 3:
            Console.WriteLine($"\nEl resultado es {Mult(num1, num2)}");
            break;
        case 4:
            Console.WriteLine($"\nEl resultado es {Div(num1, num2)}");
            break;
    }

    Console.WriteLine("\nPresione cualquier tecla para continuar");
    Console.WriteLine("Presione ESC para salir...");

    ck = Console.ReadKey();
    Console.Clear();
} while (ck.Key != ConsoleKey.Escape);


static int Suma(int num1,int num2)
{
  

    return num1 + num2;
}

static int Resta(int num1, int num2)
{
  
    return num1 - num2;
}

static int Mult(int num1, int num2)
{
 

    return num1 * num2;
}

static int Div(int num1, int num2)
{


    return num1 / num2;
}