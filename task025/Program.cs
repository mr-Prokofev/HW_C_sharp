Console.Clear();
int num = Convert.ToInt32(Console.ReadLine());
int st = Convert.ToInt32(Console.ReadLine());
if (st <= 0)
{
    Console.WriteLine("Ошибка");
    return;
}

void StNum(int a, int b)
{
    int step = 1;
    for (int i = 1; i<=b; i++)
    {
        step*=a;
    }
    Console.WriteLine($"число {a} в степени {b}: {step}");
}
StNum(num, st);
