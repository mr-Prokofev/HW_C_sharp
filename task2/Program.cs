Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное: ");
if (numA > numB)
    {
        Console.Write(numA);
    }
else
{
    Console.Write(numB);
}
