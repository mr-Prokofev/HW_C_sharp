// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());

if (PozitiveNumber(m)==false || PozitiveNumber(n)==false)
{
    Console.WriteLine("Некорректные данные");
    return;
} 
else
{
int resultAckermannFunction = AckermannFunction(m,n);
Console.WriteLine($"m = {m}, n = {n}, result = {resultAckermannFunction}");
}

int AckermannFunction(int number, int argument)
{
    if (number == 0) return argument+1;
    if (number != 0 && argument == 0) return AckermannFunction(number - 1, 1);
    if (number > 0 && argument > 0) return AckermannFunction(number - 1, AckermannFunction(number, argument - 1));
    return AckermannFunction(number, argument);
}
bool PozitiveNumber(int num)
{
    if (num>0) return true;
    else return false;
}


