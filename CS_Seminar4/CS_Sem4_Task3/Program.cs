//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов в массиве: ");  // приглашение ко вводу
int n = Convert.ToInt16(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");  // приглашение ко вводу
    array[i] = Convert.ToInt16(Console.ReadLine());
}

Console.Write("Наш массив: [" + string.Join(", ", array) + "]");
