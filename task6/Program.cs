Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(numA) % 2 == 1)
{
    Console.WriteLine($"{numA} - нет");
}
else
    {
        Console.WriteLine($"{numA} - да");
    }