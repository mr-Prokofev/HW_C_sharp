Console.Clear();

int[] ResultArray = new int[3];




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