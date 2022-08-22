//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetSumMtoN(int a, int b)
{
    if (b <= a) return a;
    return a + GetSumMtoN(a + 1, b);
}


int GetSumNtoM(int a, int b)
{
    if (b <= a) return a;
    return a + GetSumNtoM(a+1, b);
}


Console.Write("Введите число M: ");
int inputM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int inputN = Convert.ToInt32(Console.ReadLine());

if (inputM < inputN)

{
    int sum = GetSumMtoN(inputM, inputN);
    Console.WriteLine(sum);   
}
else
{
    int sum = GetSumNtoM(inputN, inputM);
    Console.WriteLine(sum);   
}


