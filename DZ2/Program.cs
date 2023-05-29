// Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     }

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//  Console.Write(message);
//  return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
// int result = 0;
//  if (b < 3)
//     {
//  Console.Write("Третьей цифры нет: ");
//     }
//  else
//     {
//  int c = 1;
//  for (int i = b; i > 3; i--)
//         {
//  c = c * 10;
//         }

//  result = (a / c) % 10;
//     }
// return result;
// }


Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WorkHoliday(dayNumber));
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
 if (a > 0 && a < 8)
    {
 if (a == 7 || a == 6)
        {
 Console.Write("Цифра " + a + " - Выходной");
        }
 else
        {
 Console.Write("Цифра" + a + " - Рабочий");
        }
    }
    else
    {
 Console.Write("День не определен");
    }
 return " день.";
}