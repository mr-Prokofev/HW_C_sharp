// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
double[] array = CreateArrayDouble(5, 0, 10);
printArray(array);
double min = MinElemDouble(array);
double max = MaxElemDouble(array);
double ResultFuncMinMax = ResultMinMax(min, max);

Console.WriteLine($"\nМинимальный {min} \nМаскимальный {max} \nРазность {ResultFuncMinMax}");

double[] CreateArrayDouble(int size, int min, int max, int round = 1) //создание массива 
{
    double[] mas = new double[size];
    Random rnd = new Random();
    for (int i = 0; i<mas.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        mas[i]= Math.Round(num,round);
    }
    return mas;
}
void printArray(double[] array) // печать массива
{
    Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {   if (i<array.Length-1) Console.Write($"{array[i]}  ");
        else Console.Write($"{array[i]}");   
    }
    Console.Write("]");
}

double MinElemDouble(double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<minElement) minElement=array[i];
    }
    return minElement;
}
double MaxElemDouble(double[] array)
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>maxElement) maxElement=array[i];
    }
    return maxElement;
}
double ResultMinMax(double minElem, double maxElem, int round = 1)
{
    double resultMinMax = Math.Round(maxElem-minElem,round);
    return resultMinMax;
}