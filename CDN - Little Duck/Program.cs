using System.Text.RegularExpressions;

string[] wrongList = { "Jorge Suarez", "36", "CDMX", "Josue Vizcarra", "31", "Tijuana", "Alba Chavez", "55", "Monterrey", "Joel Lopez", "31", "Tijuana" };

string[,] emptyArray = new string[4, 3];

int counterRow = 0;

for (int i = 0; i < wrongList.Length; i++)
{
    if (i % 3 == 0)
    {
        emptyArray[counterRow, 0] = wrongList[i];
        emptyArray[counterRow, 1] = wrongList[i+1];
        emptyArray[counterRow, 2] = wrongList[i+2];
        counterRow++;
    }              

    if(counterRow > 3)
    {
        break;
    }
}

Console.WriteLine(String.Format("{0,-15} {1,-7:D} {2:-15}",
                                 "Nombre", "Edad", "Ciudad"));
for (int i = 0;i < emptyArray.GetLength(0); i++)
{
    for( int j = 0; j < emptyArray.GetLength(1); j++)
    {
        Console.Write($"{emptyArray[i,j]}\t");
    }

    Console.WriteLine();
}