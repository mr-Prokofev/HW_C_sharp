// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.


int SumDigits(int num, int pow)
{
    if (pow == 0) return 1;    //1! = 1  0! = 1
    else return num * SumDigits(num, pow-1);
}

int PowNum = SumDigits(3,0);
Console.WriteLine(PowNum);