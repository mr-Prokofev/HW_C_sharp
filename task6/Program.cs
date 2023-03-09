Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA % 2 == 1)
{
    Console.WriteLine($"{numA} - нечетное");
}
else
    {
        Console.WriteLine($"{numA} - четное");
    }