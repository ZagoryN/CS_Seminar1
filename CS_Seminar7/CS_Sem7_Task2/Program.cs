//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

if (m <=0 || n <= 0)
{
    Console.WriteLine("Неверное количество строк или столбцов, массив не может быть инициирован.");
}
else
{
    int[,] matrix = FillMatrixRandomNumbers(m, n);

    int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 10)
    // leftRange = 0 и rightRange = 10  - значения по умолчанию
    {
        int[,] matr = new int[rows, columns];
        Random rand = new Random();

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rand.Next(leftRange, rightRange + 1);
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

    Console.WriteLine("Введите индекс строки: ");
    int p = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца n: ");
    int q = Convert.ToInt32(Console.ReadLine());

    int SearchPosition(int[,] arr, int positionRows, int positionColumns)
    {
        if (positionRows > arr.GetLength(0)-1 || positionColumns > arr.GetLength(1)-1)
        {
            Console.WriteLine("Такого числа в массиве нет");
        }
        else
        {
            Console.WriteLine($"Искомый элемент, который находится в строке {positionRows}, столбце {positionColumns}: {arr[positionRows, positionColumns]}.");
        }
        return arr[positionRows, positionColumns];
    }
    SearchPosition(matrix, p, q);
}

