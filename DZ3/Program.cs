// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// int num; 
// int rev = 0; 
// int sum = 0, n;
// Console.Write("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000000000)
// {
// for(n=num;num!=0;num=num/10)
// {
// rev=num % 10;
// sum=sum*10+rev;
// }
// if(n==sum)
// Console.Write($"{n} является палиндромом.");
// else
// Console.Write($"{n} не является палиндромом.");
// } else
// Console.Write("Введите пятизначное число! ");




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// System.Console.WriteLine("Введите координату x1: ");
// double x1 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату x2: ");
// double x2 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату y1: ");
// double y1 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату y2: ");
// double y2 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату z1: ");
// double z1 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату z2: ");
// double z2 = double.Parse(Console.ReadLine());

// double dist = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
// Console.WriteLine(dist);



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// System.Console.WriteLine($"Введите число N:");
// int n = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Таблици кубов чисел от 1 до {n}:");
// for (int i = 1; i <= n; i++)
// {
//     System.Console.Write($"{Math.Pow(i, 3)} ");
// }




// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом
int num; 
int rev = 0; 
int sum = 0, n;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if  (num>9999 && num<100000000)
{
for(n=num;num!=0;num=num/10)
{
rev=num % 10;
sum=sum*10+rev;
}
if(n==sum)
Console.Write($"{n} является палиндромом.");
else
Console.Write($"{n} не является палиндромом.");
} else
Console.Write("Введите пятизначное число! ");