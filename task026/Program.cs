Console.Clear();
int numA = Convert.ToInt32(Console.ReadLine());

int countNumA (int x)
{
    int count = 0;
    while (x!=0)
    {
        count++;
        x/=10;
    }
    return count;
}

int resFunc = countNumA(numA);
Console.WriteLine(resFunc);