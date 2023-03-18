Console.Clear();
int numA = Convert.ToInt32(Console.ReadLine());
int FactorialNumA(int x)
{
    if (x==1) return 1;
    return x * FactorialNumA(x - 1);
}

int resultFunc = FactorialNumA(numA);
Console.WriteLine(resultFunc);