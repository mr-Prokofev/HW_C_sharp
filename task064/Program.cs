// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();


void NumNatural(int num)
{
    if (num < 0)
    {
        Console.WriteLine($"{num} - не натуральное число");
        return;
    }
    if (num == 0) return;
    Console.Write($"{num} ");
    NumNatural(num-1);  
}

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
NumNatural(num);
