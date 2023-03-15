Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());



bool resultFuncCheckingTheNumber = checkingTheNumber(num) > 0 ? true: false;
if (resultFuncCheckingTheNumber == true)
{
    string result = Palindrome(checkingTheNumber(num)) ? "Да" : "Нет";
    Console.WriteLine($"{num} --> {result}");
}
else
{
    Console.WriteLine("Неккоректные данные");
}

int checkingTheNumber (int a) // Проверка на 5 знаков, преобразование в модуль.
{
    int numFunc = Math.Abs(a);
    if (numFunc > 9999 && numFunc < 100000) return numFunc;
    return 0;  
}
bool Palindrome(int x)  // Проверка на палиндром числа, полученного из функции выше
{
    string reverseNum = "";
    int last = 0;
    while (x != 0)
    {
        last = x%10;
        reverseNum+=last;
        x/=10;
        
    }
    bool resultFunc = int.Parse(reverseNum) == checkingTheNumber(num) ? true : false;
    return resultFunc;
}


