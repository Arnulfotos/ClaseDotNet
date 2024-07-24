Console.WriteLine("Bienvenido a la calculadora mas increible del mundo");

ConsoleKeyInfo ck;

do
{
    Console.WriteLine("Seleccione la figura a calcular:\n" +
       " [1] Cuadrado\n [2] Rectangulo\n [3] Triangulo\n [4] Circulo\n [0] Salir\n"
       );

    int seleccion = int.Parse( Console.ReadLine()! );

    Console.Clear();    
    switch (seleccion)
    {
        case 1:
            Console.WriteLine("Seleccionaste cuadrado");
            Console.WriteLine("Ingrese el valor de un lado\n");
            int Lado1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"El area del cuadrado es de {Lado1 * Lado1}m2 y el primetro es de {Lado1 * 4}m");
            break;
        case 2:
            Console.WriteLine("Seleccionaste rectangulo");
            Console.WriteLine("Ingrese el valor de Anchura\n");
            int Ancho = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ingrese el valor de Altura\n");
            int Alto = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"El area del rectangulo es de {Ancho * Alto} m2 y el perimetro es de {(Ancho * 2) + (Alto*2)} M");
            break;
        case 3:
            Console.WriteLine("Seleccionaste triangulo");
            Console.WriteLine("Ingrese el valor de Lado 1\n");
            int T1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ingrese el valor de Lado 2\n");
            int T2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ingrese el valor de Lado 3\n");
            int T3 = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"El area del rectangulo es de {FormulaDeHeron(T1,T2,T3)}m2 y su perimetro es de {T1 + T2 + T3}");
            Console.WriteLine($"El triangulo es {EvalTriangulo(T1, T2, T3)}");
            break;

        case 4:
            Console.WriteLine("Seleccionaste circulo");
            Console.WriteLine("Ingrese el valor del Radio\n");
            int Radio = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"El perimetro es {Math.Round((2 * Math.PI * Radio),2, MidpointRounding.ToZero)} y el radio es {Math.Round((Math.PI * Math.Pow(Radio,2)), 2, MidpointRounding.ToZero)} ");
            break;
    }




    Console.WriteLine("\nPresione cualquier tecla para continuar");
    Console.WriteLine("Presione ESC para salir...");

    ck = Console.ReadKey();
    Console.Clear();
} while (ck.Key != ConsoleKey.Escape);


 static double FormulaDeHeron(int L1, int L2, int L3)
{
    float sPerimetro = (L1 + L2 + L3) / 2;
    float calculoInterior = sPerimetro * (sPerimetro - L1) *(sPerimetro - L2) *(sPerimetro - L3);
    return Math.Round(Math.Sqrt( calculoInterior ), 2, MidpointRounding.ToZero);
}

static string EvalTriangulo(int L1, int L2, int L3)
{
    int[] lados = { L1, L2, L3 };
    string Evaluacion = "Incalculable";

    if (L1 == L2 && L2 == L3 && L1 == L3)
    {
        Evaluacion = "Equilatero";

    }

    if (L1 == L2 || L2 == L3 || L1 == L3)
    {
        Evaluacion = "Isosceles";

    }


    if (L1 != L2 && L2 != L3 && L1 != L3)
    {
        Evaluacion = "Escaleno";

    }
    
    return Evaluacion;
}