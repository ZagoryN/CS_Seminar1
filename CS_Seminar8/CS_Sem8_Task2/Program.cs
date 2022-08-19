//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

if (m <=0 || n <= 0)
{
    Console.WriteLine("Неверное количество строк или столбцов, массив не может быть инициирован.");
}
else if (m != n)
{
    Console.WriteLine("Вы собираетесь задать не квадратный массив, попробуйте ещё раз.");
}
else
{
    int[,] matrix = FillMatrix(m, n);
    int[,] FillMatrix(int rows, int columns)
    {
        int[,] matr = new int[rows, columns];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.WriteLine("Введите элемент матрицы (построчно): ");
                matr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return matr;
    }

    void PrintMatrix(int[,] matrixx)
    {
        for (int i = 0; i < matrixx.GetLength(0); i++)
        {
            for (int j = 0; j < matrixx.GetLength(1); j++)
            {
                Console.Write(matrixx[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    PrintMatrix(matrix);
// помещаем суммы в новый 1D массив, индекс элемента, на котором стоит
// сумма будет равняться номеру строки из исходного 2D массива
    int[] sumArray = new int[matrix.GetLength(1)];
    int sum = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
             sum = sum += matrix[i, j];

        }
        sumArray[i] = sum;
        sum = 0;
    }
    //Console.WriteLine();
    //Console.WriteLine("["+ string.Join("; ", sumArray) + "]");

    int index = 0;
    int minElement = sumArray[index];
    int minIndex = index;
    for (index = 1; index < sumArray.Length; index++ )
    {
        if (sumArray[index] < minElement) 
        {
            minElement = sumArray[index]; 
            minIndex = index;
        }
                
        //Console.WriteLine(minElement);
        //Console.WriteLine(minIndex);
    }
    minIndex = minIndex + 1; //т.к. нумерация строк идет не с 1, а с 0
    Console.Write($"Наименьшая сумма элементов ({minElement}) находится в {minIndex} строке массива.");
}