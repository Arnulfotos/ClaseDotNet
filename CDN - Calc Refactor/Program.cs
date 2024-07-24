using System;
//El codigo debe de contar una historia

namespace CDN___Calc_Refactor
{
    internal class Program
    {

        public enum Operaciones // Relaciona un valor con un concepto, es una manera de conceptualizar una accion
        {
            SUMA = 1, RESTA = 2, MULTIPLICACION = 3, DIVISION = 4, SALIR = 5,
        }

        public static double Suma(double num1, double num2)
        {


            return num1 + num2;
        }

        public static double Resta(double num1, double num2)
        {

            return num1 - num2;
        }

        public static double Mult(double num1, double num2)
        {


            return num1 * num2;
        }

       public static double Div(double num1, double num2)
        {


            return num1 / num2;
        }


        public static double calcular(double x, double y, Operaciones opracion)
        {
            double resultado = 0;

            switch(opracion)
            {
                case Operaciones.SUMA:
                    resultado = Suma(x,y);
                    break;
                case Operaciones.RESTA:
                    resultado = Resta(x,y);
                    break;
                case Operaciones.MULTIPLICACION:
                    resultado = Mult(x, y);              
                    break;
                case Operaciones.DIVISION:
                    resultado = Div(x,y);
                    break;
                default:
                    resultado = 0;
                    break;

             

            }
            return resultado;
        }

        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                Console.WriteLine("Seleccione la operacion a realizar:\n" +
                                    " [1] Sumar\n [2] Restar\n [3] Multiplicar\n [4] Dividir\n [5] Salir\n");


                int seleccion = int.Parse(Console.ReadLine());
                var operacion = (Operaciones)seleccion;

                if (operacion == Operaciones.SALIR)
                {
                    Console.WriteLine("Finalizando sistema");
                    active = false;
                    break;
                }

                Console.WriteLine("Ingrese el primer numero");
                double num1 = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Ingrese el segundo numero");
                double num2 = double.Parse(Console.ReadLine()!);

                double resultado = calcular(num1, num2, operacion);
                Console.WriteLine($"El resultado es {resultado}");

            }

        }
    }
}
