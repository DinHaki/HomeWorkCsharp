// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// void FillArray(double[,] array)
// {
//     for (int i =0;i<array.GetLength(0);i++)
//         for (int j =0;j<array.GetLength(1);j++)
//             array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 100;
// }

// void PrintArray(double[,] array)
// {
//     for (int i =0;i<array.GetLength(0);i++)
//         {
//         for (int j =0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }




// Console.Clear();
// System.Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов ");
// int cols = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double [rows,cols];
// FillArray(array);
// PrintArray(array);



// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве неt
Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию строки: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 3}  ");
        System.Console.WriteLine();
    }
}

void sred(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (rows2 < 1 & cols2 < 1)
                Console.Write("Позиции строк не могут быть отрицательными");
            else if (rows2 <= rows + 1 & cols2 <= cols + 1)
                Console.Write($"Значение элемента равно {array[rows2 - 1, cols2 - 1]} ");
            else
                Console.Write("Такого элемента нет в массиве");
        }
}

FillArray(array);
PrintArray(array);
sred(array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-30, 31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j], 3}  ");
//         System.Console.WriteLine();
//     }
// }

// void midle(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//             sum += array[i, j];
//         System.Console.WriteLine($"Средне арифметическое: {sum / array.GetLength(0)}");
//     }
// }

// Console.Clear();
// System.Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// midle(array);

