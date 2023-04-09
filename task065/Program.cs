// Задача 65: Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите целое число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число M");
int M = Convert.ToInt32(Console.ReadLine());

NumberNatural(N, M);
void NumberNatural(int numN, int numM)
{
    if (numN < numM) 
    {
    Console.Write($"{numN} ");
    NumberNatural(numN+1, numM);
    }
    else if (numN > numM)
    {
        Console.Write($"{numN} ");
        NumberNatural(numN-1, numM);
    }
    else
    {
        Console.WriteLine(numN);
    }
}

