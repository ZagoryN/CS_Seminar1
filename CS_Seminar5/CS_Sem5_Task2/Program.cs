//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)  // рандомайзер
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int SumOfOddPositionElements (int[] a) // Odd - нечетный
{
    int sum = 0;
    for (int i=1; i < a.Length; i+=2)
    {
        sum = sum + a[i];
    }
    return sum;
}

int[] a = FillArrayWithRandomNumbers(8,-100,1000); // наполняем массив
Console.WriteLine("[" + string.Join(", ", a) + "]"); //выводим наполненный массив

int sum = SumOfOddPositionElements(a); //вызов метода
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {sum}");

