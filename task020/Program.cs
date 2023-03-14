Console.Clear();
Console.WriteLine("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double distanceAB (int ax, int ay, int bx, int by)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) +  Math.Pow(by-ay,2));
    return result;
}

double resultFuncAndRound = Math.Round(distanceAB(7, -5, 1, -1), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и В - > {resultFuncAndRound}");
