// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void PrintMatrix(int[,] matrix) // печать матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
    {   Console.Write($"{matrix[i, j], 3}");
         
    }
    Console.WriteLine();
    }
}
void SortRowMatrixBubble(int[,] matrix) // Обход элементов матрицы и сортировка пузырьком
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int q = 0; q < matrix.GetLength(1)-1; q++)
            {
                if (matrix[i,q] < matrix[i,q+1])
                {
                    int temp = matrix[i,q+1];
                    matrix[i,q+1] = matrix[i,q];
                    matrix[i,q] = temp;
                }
            }
        }
    }
}


int[,] array2d = CreateMatrixInt(3,4,-5,5);
PrintMatrix(array2d);
SortRowMatrixBubble(array2d);
Console.WriteLine();
PrintMatrix(array2d);