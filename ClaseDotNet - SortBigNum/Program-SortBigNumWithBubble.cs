int[] arrayNums = new int[5];

for (int i = 0; i <5; i++)
{
    Console.WriteLine("Ingrese un numero");
    arrayNums[i] = int.Parse(Console.ReadLine()!);

}

static int[] bubbleSort(int[] numbers) {
    int valorLimiteDeEvaluacion = numbers.Length - 1;

bool sorteado = false;

while (!sorteado)
{

    sorteado = true;

    for(int i = 0; i < valorLimiteDeEvaluacion; i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            int temp1 = numbers[i];
            int temp2 = numbers[i + 1];

            numbers[i + 1] = temp1;
            numbers[i] = temp2;
            
            sorteado = false;
        }
    }

    valorLimiteDeEvaluacion -= 1;


}

return numbers;
}

Console.WriteLine($"\nEl numero mas grande es {arrayNums.Max()}");




int[] arraySorted = bubbleSort(arrayNums);
Console.WriteLine($"\nEl numero mas grande es {arraySorted.Last()}");

foreach(var i in arraySorted) {
    System.Console.WriteLine(i);
}