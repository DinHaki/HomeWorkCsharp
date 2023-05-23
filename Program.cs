
// System.Console.WriteLine("Введите число 1");
// int x1 = int.Parse(System.Console.ReadLine()!);
// System.Console.WriteLine("Введите число 2");
// int x2 = int.Parse(System.Console.ReadLine()!);
// if (x1>x2)
// {
//     System.Console.WriteLine($"Больше {x1}");
// }
// else 
// {
//     System.Console.WriteLine($"Больше {x2}");
// }


// System.Console.WriteLine("Введите число 1");
// int x1 = int.Parse(System.Console.ReadLine()!);
// System.Console.WriteLine("Введите число 2");
// int x2 = int.Parse(System.Console.ReadLine()!);
// System.Console.WriteLine("Введите число 3");
// int x3 = int.Parse(System.Console.ReadLine()!);
// if (x1>x2)
// {
//     System.Console.WriteLine($"Больше {x1}");
// }
// else if (x2>x3)
// {
//     System.Console.WriteLine($"Больше {x2}");
// }
// else if (x3>x2)
// {
//     System.Console.WriteLine($"Больше {x3}");
// }


// System.Console.WriteLine("Введите число");
// int x1 = int.Parse(System.Console.ReadLine()!);
// if (x1 % 2 ==0)
// {
//     System.Console.WriteLine($"{x1} Чётное ");
// }
// else 
// {
//     System.Console.WriteLine($"{x1} Нечётное");
// }



Console.WriteLine("Введите число N");
int x1 = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=x1 ;i++)
{
if (i % 2 == 0)
System.Console.Write(i + " ");
}
