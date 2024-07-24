int[,] map = {
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 1, 0, 0, 0, 0, 0},
        {0, 0, 1, 2, 1, 0, 0, 1, 0},
        {0, 0, 1, 1, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 2, 1, 1, 0, 0, 0, 0, 0},
        {0, 1, 0, 0, 1, 2, 1, 0, 0},
        {0, 3, 1, 0, 0, 1, 0, 0, 0},
        {0, 1, 0, 0, 1, 0, 0, 0, 1}
};

var mapeoDeSeñal = new int[9,9];
int counter = 0;
for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        if (map[i, j] > 1)
        {
            var nivelSeleccionado = (Niveles)map[i, j];
            switch (nivelSeleccionado)
            {
                case Niveles.Nivel1:

                    MapeadorDeSeñal(1, ref mapeoDeSeñal, map, i, j);                  
                    break;

                case Niveles.Nivel2:
                    MapeadorDeSeñal(2, ref mapeoDeSeñal, map, i, j);
                    break;

                case Niveles.Nivel3:
                    MapeadorDeSeñal(3, ref mapeoDeSeñal, map, i, j);
                    break;
            }
        } 
    }
}

//Una manera mas eficiente seria sacar las cordenadas de las antenas


for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        if (map[i,j] == 1 && mapeoDeSeñal[i,j] != 9)
        {
            counter++;
        }
    }
}

Console.WriteLine($"El total de casas sin señal es {counter}");


static void MapeadorDeSeñal(int numeroDeIteraciones,ref int[,] mapeoDeSeñal, int[,] map, int valorDeI, int valorDeJ)
{
    mapeoDeSeñal[valorDeI, valorDeJ] = map[valorDeI, valorDeJ];

    for (int k = 1; k <= numeroDeIteraciones; k++)
    {
        if (valorDeI - k >= 0) // Si la posicion del renglon, al restarle la intensidad de la antena es mayor o igual a 0(limite del index),mapea este valor.
        {
            mapeoDeSeñal[valorDeI - k, valorDeJ] = 9;
        }
        if (valorDeI + k < map.GetLength(0)) // Si la posicion del renglon, al sumarle la intensidad de la antena es menor al tamaño del array,mapea este valor.
        {
            mapeoDeSeñal[valorDeI + k, valorDeJ] = 9;
        }
        if (valorDeJ - k >= 0)
        {
            mapeoDeSeñal[valorDeI, valorDeJ - k] = 9;

        }
        if (valorDeJ + k < map.GetLength(1))
        {
            mapeoDeSeñal[valorDeI, valorDeJ + k] = 9;
        }
    }
}
enum Niveles
{
    Nivel1 = 2, Nivel2 = 3, Nivel3 = 4
}

