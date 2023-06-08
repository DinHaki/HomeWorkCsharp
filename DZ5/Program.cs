// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];
// void dlina(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next(99, 999);
//         Console.Write(randomArray[i] + " ");
//     }
// }

// int count(int[] randomArray)
// {
//     int count = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if (randomArray[i] % 2 == 0)
//             count = count + 1;
//     }
//     return count;
// }
// dlina(a);
// Console.Write($"\nКоличество чётных чисел в массиве: {count(randomArray)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];
// void dlina(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next(99, 999);
//         Console.Write(randomArray[i] + " ");
//     }
// }

// int sum(int[] randomArray)
// {
// int sum = 0;
// int i = 1;
// while (i < randomArray.Length)
// {
// sum = sum + randomArray[i];
// i = i + 2;
// }
// return sum;
// }

// dlina(a);
// Console.Write($"\nОбщая сумма числе на нечётных позициях: {sum(randomArray)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]:F2} ");
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");

