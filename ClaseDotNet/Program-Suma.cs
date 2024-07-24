Console.WriteLine("Ingrese un numero para sumar");

int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese otro numero para sumar");


int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"El resultado es {Sumador(num1,num2)}");




static int Sumador(int num1, int num2)
{
    return num1 + num2;
}