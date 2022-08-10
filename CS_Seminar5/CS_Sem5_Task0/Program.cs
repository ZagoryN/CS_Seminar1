//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] a = FillArrayWithRandomNumbers(10,100,1000); // наполняем массив
Console.WriteLine("[" + string.Join(", ", a) + "]"); //выводим на экран наполненный массив
int count = 0;

for (int i=0; i < a.Length; i++)
{
    if (a[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве - {count}.");
