// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int[,] CreateMatrixInt(int rows, int colums, int min, int max) // Создание матрицы из псевдослучайных чисел
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
void PrintMatrix(int[,] matrix) //печать матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
    {   Console.Write($"{matrix[i, j], 3}");
         
    }
    Console.WriteLine();
    }
}
int RowWithSmallestSumOfElements(int[,] matrix)
{
    int minLineSum = int.MaxValue;
    int indexMinRow = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)  // Складывает и проверяет с прошлым значением суммы строки
    {
        int sumLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumLine+=matrix[i,j];
        }
        if (sumLine<minLineSum) 
        {
            minLineSum = sumLine;
            indexMinRow = i;
        }
    }
    return indexMinRow;
}

int[,] array2d = CreateMatrixInt(3, 3, -5, 5);
PrintMatrix(array2d);
int minRow = RowWithSmallestSumOfElements(array2d);
Console.WriteLine($"Строка с наименьшей суммой элементов - {minRow+1}");
