Console.Clear();
int[] array = new int[8];

int [] arrayZap(int [] x)
{
    Random random = new Random();
     
     for (int i = 0; i<x.Length; i++)
     {
        x[i] = random.Next(0,2);
    }
     return x;
}

void PrintArray(int[] x1)
{
    for (int j = 0; j<x1.Length; j++) 
    {
        Console.Write("{0} ", x1[j]);
    }
}

PrintArray(arrayZap(array));