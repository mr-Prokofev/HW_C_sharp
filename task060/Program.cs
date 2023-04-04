//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

int[,,] CreateArray3d(int rows, int colums, int depth, int[] array)
{
    
    int[,,] array3d = new int[rows, colums, depth];

    int temp = 0;
    
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i,j,k]= array[temp];
                temp++;
            }
            
        }   
    }
    return array3d;
}
void Print3DArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})");
      }
      Console.WriteLine();
    }
  }
}

bool Verification(int rows, int colums, int depth) // Двоичных чисел не больше 90?
{
    if (rows*colums*depth < 91) return true;
    else return false;  
}
int[] ArrayOfTwoDigitNumbers(int rows, int colums, int depth)
{   Random rnd = new Random();
    int[] numArrayTwoDigit = new int[rows*colums*depth];
    
    for (int q = 0; q < numArrayTwoDigit.Length; q++) //Массив с двоичными числами
    {
        numArrayTwoDigit[q] = 10+q;
    }
    for (int i = numArrayTwoDigit.Length - 1; i >= 1; i--) //Перемешивание массива с помощью перестановки - Алгоритм Фишера
    {
        int j = rnd.Next(i + 1);
        int tmp = numArrayTwoDigit[j];
        numArrayTwoDigit[j] = numArrayTwoDigit[i];
        numArrayTwoDigit[i] = tmp;
    }
    return numArrayTwoDigit;
}

// Пользователь вводит измерения
Console.WriteLine("Введите Х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z:");
int z = Convert.ToInt32(Console.ReadLine());


if (Verification(x,y,z) == true)
{   int[] arrayOfTwoDigitNumbers = ArrayOfTwoDigitNumbers(x,y,z); // Создаем массив двоичных чисел и перемешиваем
    int[,,] array3d = CreateArray3d(x,y,z, arrayOfTwoDigitNumbers); 
    Print3DArray(array3d);
}
else{
    Console.WriteLine("Error");
}
