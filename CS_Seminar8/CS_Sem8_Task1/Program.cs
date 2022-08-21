//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

if (m <=0 || n <= 0)
{
    Console.WriteLine("Неверное количество строк или столбцов, массив не может быть инициирован.");
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

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;

        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            if (matrix[i,j] > matrix[i,j + 1])
            {
                temp = matrix[i,j + 1];
                matrix[i,j + 1] = matrix[i,j];
                matrix[i,j] = temp;
            }            
    }
    //Console.WriteLine();
    //PrintMatrix(matrix);

    for (int sort = 0; sort < matrix.GetLength(0); sort++)
    {
        int bufer = 0;

        for (int j = 0; j < matrix.GetLength(1)-2; j++)
        {
            if (matrix[sort,j+1] < matrix[sort,j])
            {
                bufer = matrix[sort,j];
                matrix[sort,j] = matrix[sort, j+1];
                matrix[sort,j+1] = bufer;
            }

        }
    }
    Console.WriteLine();
    PrintMatrix(matrix);
}
}



