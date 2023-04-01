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
bool Verification(int row, int col, int[,] matrix)
{
    return row <= matrix.GetLength(0) && col <= matrix.GetLength(1) && row > 0 && col > 0;
}

int[,] array2d = CreateMatrixInt(3,4, 0, 10);
printMatrix(array2d);

Console.WriteLine("Строка"); /// Вариант для пользователя с 1
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столбец"); /// Вариант для пользователя с 1
int col = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Verification(row, col, array2d) ? $"Искомый элемент в позиции ({row},{col}), равен {array2d[row-1,col-1]}" : "Неккоректные данные");
