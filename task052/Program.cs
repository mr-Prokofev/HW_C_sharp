// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
double[] AverageColumns(int[,] matrix) // обход по столбцам
{double[] arrayResult = new double[matrix.GetLength(1)];
double count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           count+=matrix[i,j]; 
        }
        arrayResult[j] = count/matrix.GetLength(0);
        count = 0;
    }
    return arrayResult;
}
void printArray(double[] array) // печать массива
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{Math.Round(array[i],1)}  ");
        else Console.Write($"{Math.Round(array[i],1)}");   
    }
    Console.Write("]");
}

int[,] array2d = CreateMatrixInt(4,3,1,5);
double[] ArrayAverageColumns = AverageColumns(array2d);
printMatrix(array2d);
Console.WriteLine("Среднее арифметическое:");
printArray(ArrayAverageColumns);
