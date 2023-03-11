int MaxNumber (int A)
{
    int firstDigit = A / 10;
    int secondDigit = A % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}
int TwoDigits (int B)
{
    int firstDigit = B/100;
    int threeDigit = B%10;
    int newNumber = firstDigit*10 + threeDigit;
    return newNumber;
}
int Multiplicity (int C, int D)

{
    int remains = C % D;
    
    int result = remains == 0 ? 0 : remains;
    return result;
}
void Multiplicity1(int E)
{
    int result = E%7 + E%23;
    Console.WriteLine(result == 0? "Да": "Нет");
}
void Square(int G, int H)
{
    Console.WriteLine(G == H*H || H == G*G ? "Yes" : "No");
    
}

int num = new Random().Next(10, 100);
int num1 = new Random().Next(100, 1000);


MaxNumber(num);
TwoDigits(num1);
Multiplicity(16, 4);
Multiplicity1(14);
Multiplicity1(46);
Multiplicity1(161);
Square(5, 25);
Square(-4, 16);
Square(25, 5);
Square(8, 9);



