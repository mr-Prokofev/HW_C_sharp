//Задача 63: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N
Console.Clear();
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
NumberNatural(num);
void NumberNatural(int num)
{
    if (num == 0) return;
    NumberNatural(num-1);
    Console.Write($"{num} ");
}
