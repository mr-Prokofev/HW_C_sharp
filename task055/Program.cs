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
int[,] NewMatrixMethod(int[,] matrix)
{
    int[,] NewMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            NewMatrix[i,j] = matrix[j,i];
        }
    }
    return NewMatrix;
}
void ChangeColRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(0); j++)
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
}
bool Verification(int r, int c)
{
    return r != c || r < 0 || c < 0;
}

Console.WriteLine("Введите количество строк");
int rowsUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colUser = Convert.ToInt32(Console.ReadLine());

if (Verification(rowsUser, colUser))
{
    Console.Write("Введены неверные данные");
    return;
}

int[,] array2d = CreateMatrixInt(rowsUser,colUser,-5,5);
PrintMatrix(array2d);
Console.WriteLine();
PrintMatrix(NewMatrixMethod(array2d));
Console.WriteLine();
ChangeColRow(array2d);
PrintMatrix(array2d);

