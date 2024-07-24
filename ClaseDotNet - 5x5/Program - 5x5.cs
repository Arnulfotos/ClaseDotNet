int[,] matrix5by5 = new int[5,5];
int count = 1;
for(int i = 0; i < 5; i++){

for(int j = 0;  j < 5; j++){

matrix5by5[i,j] = count;
count++;
}

}

for(int i = 4; i > -1; i--)
{

for(int j = 4;  j > -1; j--)
{

System.Console.Write(matrix5by5[i,j] + "\t"); 

}
System.Console.WriteLine();
}
