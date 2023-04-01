Console.Clear();

double[,] CreateMatrixDouble(int rows, int colums, int min, int max) //заполнение случайными вещественными числами
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= rnd.NextDouble()* (max - min) + min;
        }   
    }
    return matrix;
}
void printMatrixRound(double[,] matrix) // вывод округленных значений
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
    {
        Console.Write($"{Math.Round(matrix[i, j], 1), 5}"); 
    }
    Console.WriteLine();
    } 
}

double[,] array2d = CreateMatrixDouble(3,4, -10, 10);
printMatrixRound(array2d);