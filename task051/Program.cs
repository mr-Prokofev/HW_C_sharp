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
int MainDiagonal(int[,] matrix)
{int countElDiagonal = 0;
int min = matrix.GetLength(0) > matrix.GetLength(1) ? matrix.GetLength(1) : matrix.GetLength(0);
    for (int i = 0; i < min; i++)
    {
        countElDiagonal+=matrix[i,i];
    }
    return countElDiagonal;
}

int[,] array2d = CreateMatrixInt(6,3, -10, 10);
int count = MainDiagonal(array2d);
printMatrix(array2d);
Console.WriteLine($"Сумма элементов главной диагонали: {count}");


