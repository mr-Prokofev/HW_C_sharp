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
void SwapLineOneLastMatrix(int[,] matrix)
{int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = temp;       
    }
}



int[,] array2d = CreateMatrixInt(3,4,-5,5);
PrintMatrix(array2d);
Console.WriteLine();
SwapLineOneLastMatrix(array2d);
PrintMatrix(array2d);