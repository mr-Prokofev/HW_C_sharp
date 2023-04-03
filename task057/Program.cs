Console.Clear();

int[,] CreateMatrixInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= rnd.Next(min, max+1);
        }   
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
    {   Console.Write($"{matrix[i, j], 3}");
         
    }
    Console.WriteLine();
    }
    
    
}

int[] ArrayNums(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)*matrix.GetLength(1)];
    int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i,j];
            index++;
        }
    }
    return array;
}
void PrintArray(int[] array) // печать массива
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]}  ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
}

void PrintNumsCount(int[] arr)
{
    
    int temp = arr[0];
    int count = 1;
    string a = "";
    for (int i = 1; i < arr.Length; i++)
    {
        if (temp == arr[i]) count++;
        else
        {   if (count == 2 || count == 3 || count ==4) a="а";
            else a ="";
            Console.WriteLine($"{temp} встречается {count} раз{a}");
            temp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз{a}");
    
}




int[,] array2d = CreateMatrixInt(3,4,1,15);
int[] ResultFuncArrayNums = ArrayNums(array2d);
PrintMatrix(array2d);

Console.WriteLine();
Array.Sort(ResultFuncArrayNums);
PrintArray(ResultFuncArrayNums);
Console.WriteLine();
PrintNumsCount(ResultFuncArrayNums);