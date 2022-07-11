//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");  // приглашение ко вводу
int a = Convert.ToInt32(Console.ReadLine()); // вводим число a
Console.Write("Введите второе число: ");  // приглашение ко вводу
int b = Convert.ToInt32(Console.ReadLine()); // вводим число b
if (a > b)
{
    int max = a;
    int min = b;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.Write(min);
}
else 
{
    int max = b;
    int min = a;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.Write(min);
}