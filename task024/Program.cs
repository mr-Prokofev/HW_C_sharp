Console.Clear();
int numA = Convert.ToInt32(Console.ReadLine());

int sumNumA(int x)
{
    int simI = 0;
    for (int i = 1; i<=x; i++)
    {
        simI+=i;
    }
    return simI;
}

int resFunc = sumNumA(numA);
Console.WriteLine(resFunc);