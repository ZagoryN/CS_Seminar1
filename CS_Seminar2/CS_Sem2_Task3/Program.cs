//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите день недели от 1 до 7: ");  // приглашение ко вводу
int N = Convert.ToInt32(Console.ReadLine()); // ввод числа, обозначающего день недели
Console.Write("Является ли этот день выходным? ");  // приглашение ко вводу
switch(N)
{
    case 1:
    Console.WriteLine("Нет (понедельник)");
    break;

    case 2:
    Console.WriteLine("Нет (вторник)");
    break;

    case 3:
    Console.WriteLine("Нет (среда)");
    break;

    case 4:
    Console.WriteLine("Нет (четверг)");
    break;

    case 5:
    Console.WriteLine("Нет (пятница)");
    break;


    case 6:
    Console.WriteLine("Да (суббота)");
    break;

    case 7:
    Console.WriteLine("Да (воскресенье)");
    break;

    default:
    Console.WriteLine("Нет такого дня недели");
    break;
}