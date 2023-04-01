Console.Clear();

int[,] CreateMatrixInt(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= i+j;
        }   
    }
    return matrix;
}
void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
    {   Console.Write($"{matrix[i, j], 3}");
         
    }
    Console.WriteLine();
    }
    
    
}


int[,] array2d = CreateMatrixInt(3,4);
printMatrix(array2d);