Console.WriteLine("X");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Y");
int Y1 = Convert.ToInt32(Console.ReadLine());

int Coordinate(int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}

Console.WriteLine($"Четверь: {Coordinate(X1,Y1)}");



