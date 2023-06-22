// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string SummaRec(int num)
{
    if (num == 0) return string.Empty;
else return $"{num}, " + SummaRec(num - 1);
}

System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaRec(num));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int SummaRec (int num,int num2)
// {
//     if (num == num2) return (num2);
// else return num + SummaRec (num + 1, num2);
// }


// System.Console.WriteLine("Введите целое число M ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите целое число N ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SummaRec(num, num2));
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SummaRec(num,num2)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AckerFunction (int M, int N)
// {
//     if (M == 0) return N + 1;
//     if (M != 0 && N == 0) return AckerFunction(M - 1, 1);
//     if (M > 0 && N > 0) return AckerFunction(M - 1, AckerFunction(M, N - 1));
// return AckerFunction(M, N);
// }


// Console.WriteLine("Введите начальное число M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начальное число N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckerFunction(M, N)}");