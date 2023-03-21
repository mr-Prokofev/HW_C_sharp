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

int[] array = CreateArray(12, -9, 9);

int sumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum +=arr[i]; 
    }
    return sum;
}

int sumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum +=arr[i]; 
    }
    return sum;
}

int sumPositiveElement = sumPositiveElem(array);
int sumNegativeElement = sumNegativeElem(array);
Console.WriteLine($"{sumPositiveElement}, {sumNegativeElement}");
printArray(array);