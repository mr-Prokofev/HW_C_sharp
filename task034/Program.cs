// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Введите длину массива:");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayPozitive(lengthArray);
int count = CountOfEvenNumbers(array);
printArray(array);
Console.WriteLine($" --> {count}");

int[] CreateArrayPozitive(int size) //создание массива из положительных трехзначных чисел
{
    int[] mas = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<mas.Length; i++)
    {
        mas[i]= rnd.Next(100, 1000);
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
int CountOfEvenNumbers(int[] arr) // подсчет четных чисел
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) count++;
    }
    return count;
}