// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("введите цифру от 1 до 7!"); // все верно
int a = Convert.ToInt32(Console.ReadLine()); // все верно

switch (a) 
{ //может быть любое колво ситуаций
    case 1:
      Console.WriteLine("нет, будний");
      break;
    case 2:
       Console.WriteLine("нет, будний");
       break;
    case 3:
       Console.WriteLine("нет, будний");
       break;
    case 4:
       Console.WriteLine("нет, будний");
       break;
    case 5:
       Console.WriteLine("нет, будний");
       break;
    case 6:
       Console.WriteLine("да, выходной");
       break;
    case 7:
      Console.WriteLine("да, выходной");
      break;
    default:
      Console.WriteLine("ошибка");
      break;
}