Console.Clear();
Console.WriteLine("Четверть?");
string plane = Console.ReadLine();

string Values(string x)
{
    if (x == "1") return $"Диапозон: x>0 y>0";
    if (x == "2") return $"Диапозон: x<0 y>0";
    if (x == "3") return $"Диапозон: x<0 y<0";
    if (x == "4") return $"Диапозон: x>0 y<0";
    return "Неверное значение";
}

string s = Values(plane);
Console.WriteLine(s);
