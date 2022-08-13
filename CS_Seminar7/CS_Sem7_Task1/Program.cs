//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// опишем метод, как печатать массив 

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //распечатываем массив
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); //переход на новую строку для красивого отображения
    }
}

//опишем метод для заполнения массива
void FillArray(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++) //распечатываем массив
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= rand.NextDouble() * 1000; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            //Console.Write("{0,6:F2}", matr[i, j]);;   
        }
    }
}


double[,] matrix = new double[3,4];  //выделяем память, инициализация массива

PrintArray(matrix); // вызываем метод

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); 