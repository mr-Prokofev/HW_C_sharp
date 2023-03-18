Console.Clear();
int[] array = new int[8];

int[] arrZap(int[] b)
{
    Random random = new Random();
    for (int j = 0; j<b.Length; j++)
    {
        b[j] = random.Next(1, 100);
    }
    return b;
}

void printArray(int[] a)
{
    for (int i =0; i<a.Length; i++)
    {
        Console.Write("{0} ", a[i]);
    }
}

printArray(array);
Console.WriteLine();
arrZap(array);
printArray(array);
