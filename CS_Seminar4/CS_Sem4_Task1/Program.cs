//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");  // приглашение ко вводу
int A = Convert.ToInt32(Console.ReadLine()); // ввод числа A
Console.Write("Введите степень. в которую нужно возвести А: ");  // приглашение ко вводу
int B = Convert.ToInt32(Console.ReadLine()); // ввод числа B
int result = 1;
for (int i=1; i <= B; i++)
{
    result=result*A;
}
Console.Write(result);