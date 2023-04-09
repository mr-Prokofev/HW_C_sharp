// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

int SummaNumNatural(int num1,int num2)
{
    if (num1 > num2)
    {
        return num1 + SummaNumNatural(num1-1, num2);
    }
    else if (num1 < num2)
    {
        return num1 + SummaNumNatural(num1+1, num2);
    }
    else
    {
        return num1;
    }
}

Console.WriteLine("Введите натуральное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = SummaNumNatural(numM, numN);
Console.WriteLine(sum);