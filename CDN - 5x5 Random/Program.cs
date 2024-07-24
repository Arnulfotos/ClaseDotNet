int[,] matrix = new int[5, 5];

var rand = new Random();

for (int i = 0; i < 5; i++)
{
    for(int j = 0; j <5; j++)
    {
        matrix[i, j] = rand.Next(1,101);    
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
       Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int count = 0;

for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        if(j == count)
        { 

        Console.Write(matrix[i, j] + "\t");
       
        }
        else
        {
            Console.Write("-\t");
        }
    }
    count++;
    Console.WriteLine();
}
Console.WriteLine();
count = 4;

for (int i = 4; i >= 0; i--)
{

    for (int j = 4; j >= 0; j--)
    {
        if (j == count)
        {

            Console.Write(matrix[i, j] + "\t");

        }
        else
        {
            Console.Write("-\t");
        }
    }
    count--;
    Console.WriteLine();
}