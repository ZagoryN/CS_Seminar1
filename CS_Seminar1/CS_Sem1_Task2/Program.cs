//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");  // приглашение ко вводу
int a = Convert.ToInt32(Console.ReadLine()); // вводим число a
Console.Write("Введите второе число: ");  // приглашение ко вводу
int b = Convert.ToInt32(Console.ReadLine()); // вводим число b
Console.Write("Введите третье число: ");  // приглашение ко вводу
int c = Convert.ToInt32(Console.ReadLine()); // вводим число с

if (a > b && a > c)
{
    int max = a;
    Console.Write("max = ");
    Console.WriteLine(max);
}
if (b > a && b > c)
{
    int max = b;
    Console.Write("max = ");
    Console.WriteLine(max);
}
if (c > a && c > b)
{
    int max = c;
    Console.Write("max = ");
    Console.WriteLine(max);
}