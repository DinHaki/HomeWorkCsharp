// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.
// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine()); 
// int C = 1;
// if (B < 0 );
// else
//  {
//     while (B!=0)
//     {
//     C = C * A;
//     B = B - 1;
//     }
//  }
// Console.WriteLine($"Число A в сетпени B будет = {C}");



// Задача 27:Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Console.WriteLine("Введите целое число\n");
// int A = Convert.ToInt32(Console.ReadLine()); 
// int index = 0;
// int sum = 0;
// int Len = Length(A);
// int Length (int A)
// {
//    while (A > 0)
//    {
//       A /= 10;
//       index++;
//    }
//    return index;
// }
// int Sum(int A, int Len)
//    {
//       for (int i =1; i <= Len; i++)
//       {
//       sum += A % 10;
//       A /= 10;
//       }
//       return sum;
//    }

// Console.WriteLine($"Сумма всех цифр в числе {A} = {Sum(A,Len)} ");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] array = new int [8];
// void Prog(int[] arr)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(10);
//       Console.Write($"{array[i]} ");
//    }
// }
// Prog(array);



// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
Console.WriteLine("Введите любое число\n");
int A = Convert.ToInt32(Console.ReadLine()); 
int index = 0;
int sum = 0;
int Len = Length(A);
int Length (int A)
{
   while (A > 0)
   {
      A /= 10;
      index++;
   }
   return index;
}
int Sum(int A, int Len)
   {
      for (int i =0; i <= Len; i++)
      {
      sum = A % 10;
      A = A / 10;
      sum +=i;
      }
      return sum;
   }
Console.WriteLine($"Количество цифр в числе {A} = {Sum(A,Len)} ");