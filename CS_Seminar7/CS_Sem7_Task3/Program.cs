//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixRandomNumbers(m,n);

int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 10)
// leftRange = 0 и rightRange = 10  - значения по умолчанию
{
    int[,] matr = new int[rows,columns];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rand.Next(leftRange, rightRange+1);
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
            Console.Write(matrixx[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);

float sum = 0;
//float result = 1;

float[] Array = new float[matrix.GetLength(1)];

for (int j = 0; j < n; j++)
    {
         for (int i = 0; i < m; i++)
        {
            sum = sum += matrix[i,j];
             
        }
        Array[j] = sum/m;

        //Console.Write(sum) ; Console.WriteLine($" {result}");
                sum = 0;
    }
    Console.WriteLine(string.Join("; ", Array));
// int[] Array = new int[matrix.GetLength(0)];
//     //int k = 0;

//     int sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int i = 0;
//         sum = sum + matrix[i, j];
//         for (int k=0; k < Array.Length; k++) 
//         {
//             Array[k]=sum;
//             i++;
//         }
//     }
    
    
// Console.WriteLine("Получившийся массив: [" + string.Join("; ", Array) + "]");
