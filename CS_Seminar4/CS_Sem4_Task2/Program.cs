//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите число A: ");  // приглашение ко вводу
int A = Convert.ToInt32(Console.ReadLine()); // ввод числа A

if (A > 0)    //на случай ввода отрицательных чисел int
{
    int N = A; //для красивого вывода результата

    double temp = 0;
    while (A > 10) 
    {
        double b = A % 10;
        A = A / 10;
        temp = temp + b;   
    }
    temp = A + temp;
    Console.WriteLine($"Сумма цифр в числе {N}: {temp}.");
}
else
{
    int N = A; //для красивого вывода результата
    A = Math.Abs(A);  //при отрицательных числах работаем с модулем числа

    double temp = 0;
    while (A > 10) 
    {
        double b = A % 10;
        A = A / 10;
        temp = temp + b;   
    }
    temp = A + temp;
    Console.WriteLine($"Сумма цифр в числе {N}: {temp}.");
}
//Console.WriteLine(result);
//Console.WriteLine(temp);


