
//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Write("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Неверное количество строк или столбцов, массив не может быть инициирован.");
}
else
{
    int[,] matrix = new int[m, n];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = n; 

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col = col + dx;
        row = row + dy;
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
}

//При решении задачи использована логика из статьи 
//https://stackoverflow.com/questions/4109836/help-with-spiral-matrix
