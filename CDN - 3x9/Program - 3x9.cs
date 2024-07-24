
int[,] abcd = new int[3, 9];

int A = 65;

for (int i = 0; i < abcd.GetLength(0); i++)
{

    for (int j = 0; j < abcd.GetLength(1); j++)
    {
        abcd[i, j] = A;
        A++;
        if(A == 79)
        {
            abcd[i, j + 1] = (char)0209;
            j++;
        }
        if (A >= 91)
        {
            break;
        }

    }

}


for (int i = 0; i < abcd.GetLength(0); i++)
{
    for (int j = 0; j < abcd.GetLength(1); j++)
    {

        System.Console.Write((char)abcd[i, j] + "\t");

    }
    System.Console.WriteLine();
}
