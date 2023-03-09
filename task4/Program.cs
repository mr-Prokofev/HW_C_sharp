Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int numC = Convert.ToInt32(Console.ReadLine());

int maxNum = Math.Max(numA, Math.Max(numB,numC));
Console.WriteLine($"Максимальное число: {maxNum}");
