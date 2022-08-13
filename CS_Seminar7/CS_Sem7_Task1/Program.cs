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
            Console.Write("{0,6:F2}", matr[i, j]);;  // выводим 2 знака после запятой
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
            matr[i,j]= rand.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        }
    }
}

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
    double[,] matrix = new double[m, n];  //выделяем память, инициализация массива

    FillArray(matrix);   // вызываем методы
    Console.WriteLine();
    PrintArray(matrix);
}
