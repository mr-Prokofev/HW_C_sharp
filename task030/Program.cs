Console.Clear();
int[] array = new int[8];

int [] arrayZap(int [] x)
{
     int temp = 0;
     for (int i = 0; i<x.Length; i++)
     {
         temp = new Random().Next(0,2);
         x[i] = temp;
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