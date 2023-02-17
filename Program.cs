// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// //6 -> да
// //7 -> да
// //1 -> нет

// Console.WriteLine("введите цифру от 1 до 7!"); // все верно
// int a = Convert.ToInt32(Console.ReadLine()); // все верно

// switch (a) 
// { //может быть любое колво ситуаций
//     case 1:
//       Console.WriteLine("нет, будний");
//       break;
//     case 2:
//        Console.WriteLine("нет, будний");
//        break;
//     case 3:
//        Console.WriteLine("нет, будний");
//        break;
//     case 4:
//        Console.WriteLine("нет, будний");
//        break;
//     case 5:
//        Console.WriteLine("нет, будний");
//        break;
//     case 6:
//        Console.WriteLine("да, выходной");
//        break;
//     case 7:
//       Console.WriteLine("да, выходной");
//       break;
//     default:
//       Console.WriteLine("ошибка");
//       break;
// }


// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1
// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int c = a % 100 / 10;
// if (a / 100 > 1 && a / 100 < 10)
// Console.WriteLine(c);
// else
// Console.WriteLine("это не трехзначное число");

// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 < 1)
Console.WriteLine("третьей цифры нет");
else if (a / 100 > 1 && a / 100 < 10)
Console.WriteLine(a % 100 % 10);
else 
  while (a > 999) // этот цикл ввела чтобы сделать число трехзначным
  {
    a /=10;
  }
Console.WriteLine(a % 100 % 10);