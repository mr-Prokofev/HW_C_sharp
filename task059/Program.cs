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
int[] MinIndex(int[,] matrix)
{
    
    int[] MinIndexArray = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < matrix[MinIndexArray[0], MinIndexArray[1]]) 
            {
                MinIndexArray[0] = i;
                MinIndexArray[1] = j;
            }

        }
    }
    return MinIndexArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
    Console.WriteLine();
}

int[,] NewMatrixDelRowAndCol(int[,] matrix, int[] cordinate)
{
    int[,] NewMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];

    for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
    {
        if (i == cordinate[0]) continue;
        for (int j = 0, newCol = 0; j < matrix.GetLength(1); j++)
        {
            if (j == cordinate[1]) continue;
            NewMatrix[newRow, newCol] = matrix[i,j];
            newCol++;
        }
        newRow++;
    }

    return NewMatrix;
}

int[,] array2d = CreateMatrixInt(4,4,0,5);
int[] MinIndexArray = MinIndex(array2d);
PrintMatrix(array2d);
printArray(MinIndexArray);
int[,] NewMatrix = NewMatrixDelRowAndCol(array2d,MinIndexArray);
PrintMatrix(NewMatrix);