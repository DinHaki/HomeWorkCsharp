// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел");
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива" );
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int kolich(int[] array)
{
    int i =0;
    int sum = 0 ;
    while (i < arr.Length)
    {
        if (arr[i]>0)
        sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

mas(a);
System.Console.WriteLine($"Чисел больше нуля: {kolich(arr)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.WriteLine("Введите координату b1");
// Double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату k1");
// Double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату b2");
// Double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату k2");
// Double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// System.Console.WriteLine($"Точка пересечения двух прямых {x} {y}");