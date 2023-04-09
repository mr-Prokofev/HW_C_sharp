//Задача 67: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр
Console.Clear();


int SumDigitsNum(int n)
{
      if (n == 0) return 0;
      else return  SumDigitsNum(n/10) + n%10;
  }

 Console.WriteLine(SumDigitsNum(363)); // 3628800