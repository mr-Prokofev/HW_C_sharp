// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();

int [] array = CreateArray(10, -99, 150);


int[] CreateArray(int size, int min, int max)
{
    int[] mas = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<mas.Length; i++)
    {
        mas[i]= rnd.Next(min, max+1);
    }
    return mas;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
}

int CountTwo(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>9 && array[i]<100) count++;
    }
    return count;
}