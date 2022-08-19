//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Write("Введите число строк m первого массива: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n первого массива: ");  
int n = Convert.ToInt32(Console.ReadLine());

if (m <=0 || n <= 0)
{
    Console.WriteLine("Неверное количество строк или столбцов, массив не может быть инициирован.");
}
else
{
    int[,] matrix1 = FillMatrixRandomNumbers(m, n);

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

    PrintMatrix(matrix1);

    Console.WriteLine("Введите число строк p второго массива: ");
    int p = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов q второго массива: ");
    int q = Convert.ToInt32(Console.ReadLine());

    if (m <=0 || n <= 0)
{
    Console.WriteLine("Неверное количество строк или столбцов, массив не может быть инициирован.");
}
else
{
        int[,] matrix2 = FillMatrixRandomNumbers(m, n);

        PrintMatrix(matrix2);

        if (m == p && n == q)
        {
            int[,] composedMatrix = new int[m, n];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    composedMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            Console.WriteLine();
            PrintMatrix(composedMatrix);
        }
        else
        {
            Console.WriteLine("Произведение матриц невозможно вычислить");
        }
    }
}