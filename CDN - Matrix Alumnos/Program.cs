using System.Text.RegularExpressions;

Console.WriteLine("Bienvenido al registro de ITStep");
string[,] tabla = new string[5,3];

for (int i = 0; i < tabla.GetLength(0); i++)
{
    tabla[i,0] = (i + 1).ToString();
    Console.WriteLine("\nIngrese el nombre del alumno");
    tabla[i, 1] = Console.ReadLine();
    Console.WriteLine("\nIngrese la materia favorita del alumno");
    tabla[i, 2] = Console.ReadLine();

    Console.WriteLine($"Fin del registro del alumno {i+1}");
    Task.Delay(1000).Wait();

    Console.Clear();
}



Console.WriteLine("Busque un alumno por su nombre");
string busqueda = Console.ReadLine();
string resultados = "";

for(int i = 0; i < tabla.GetLength(0); i++)
{
    if(tabla[i,1].ToLower().Contains(busqueda.ToLower()))
    {
        resultados = String.Format("{0,-3} {1,-20:D} {2:N}\n",tabla[i,0], tabla[i, 1], tabla[i, 2]);

    }
}

Console.WriteLine(string.IsNullOrEmpty(resultados) ? "No se encontro un alumno con ese nombre" : resultados);



