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
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        matrixResult[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
        }
       
    }
    return matrixResult;
}


Console.WriteLine("Введите размерность матриц:");
int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());

int[,] array2dEx1 = CreateMatrixInt(row, col, 1,4);
int[,] array2dEx2 = CreateMatrixInt(col, row, 1,4);
PrintMatrix(array2dEx1);
Console.WriteLine();
PrintMatrix(array2dEx2);
Console.WriteLine();
int[,] matrixResult = MatrixMultiplication(array2dEx1,array2dEx2);
PrintMatrix(matrixResult);