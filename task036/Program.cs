// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] array = CreateArray(5,-100, 100);
int sumOfTheNumbers = SumOfTheNumbers(array);
printArray(array);
Console.WriteLine($" --> {sumOfTheNumbers}");


int[] CreateArray(int size, int min, int max) //создание массива 
{
    int[] mas = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<mas.Length; i++)
    {
        mas[i]= rnd.Next(min, max);
    }
    return mas;
}
void printArray(int[] array) // печать массива
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
}

int SumOfTheNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}