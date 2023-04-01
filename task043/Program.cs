Console.Clear();

Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = SearchX(b1, k1, b2, k2);
double y1 = SearchY(x, b1, k1);
double y2 = SearchY(x, b2, k2);
string resultFunc = ValidateLine(y1, y2) == true ? "Прямые пересекаются" : "Прямые не пересекаются";
Console.WriteLine($"{resultFunc}");

bool ValidateLine(double y1, double y2)
{
    if (y1 == y2) return true;
    else return false;
}


double SearchX(double b1,double k1,double b2,double k2) // Вычисление Х
{
    double x = (b2-b1)/(k1-k2);
    return x;
}
double SearchY(double x, double b, double k)
{
    double y = k*x + b;
    return y;
}

