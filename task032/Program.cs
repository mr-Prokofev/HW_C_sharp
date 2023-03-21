Console.Clear();



int[] CreateArray(int size, int min, int max)
{
    int[] mas = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<mas.Length; i++)
    {
        mas[i]= rnd.Next(min, max+1);
    }
    return mas;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
}

void SwapNegativePozitive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 )
        {
            array[i] = Math.Abs(array[i]);
        }
        else
        {
            array[i] = - array[i];
        }
    }
}

int[] array = CreateArray(4, -9, 9);


printArray(array);
SwapNegativePozitive(array);
Console.WriteLine();
printArray(array);

