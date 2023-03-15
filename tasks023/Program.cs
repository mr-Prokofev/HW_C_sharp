Console.Clear();
Console.WriteLine("Введите предел: ");
int limit = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=limit; i++)
{
    Console.WriteLine($"{i, 3} - > {Math.Pow(i,3), 5} ");
}

