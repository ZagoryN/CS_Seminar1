//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

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

int[] a = FillArrayWithRandomNumbers(123,-100,101); // наполняем массив
Console.WriteLine("[" + string.Join(", ", a) + "]"); //выводим наполненный массив
int count = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 9 && a[i] < 100)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] - {count}.");