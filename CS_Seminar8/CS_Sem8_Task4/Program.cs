//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

Console.Write("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов k: ");  
int k = Convert.ToInt32(Console.ReadLine());

if (m * n * k <= 0 || m * n * k > 90)
{
    Console.Write("Двузначных чисел либо нет, либо не хватит для заполнения ими трехмерного массива, либо заполняется не трехмерный массив");
}

else
{
    void Shuffle(int[] arr)
    {
    // создаем экземпляр класса Random для генерирования случайных чисел
    Random rand = new Random();
 
    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
 
        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
    }

    int[] FillArrayNumbOf2Digits(int size) 
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
         {
            int minElement = 10;
            arr[0] = minElement;
            while (i+1 < arr.Length)
            {
                arr[i+1] = minElement+1;
                i++;
                minElement++;
            }
         }
        return arr;
    }           
    
      
    

    int[] arrayRand = FillArrayNumbOf2Digits(90); // массив двузначных неповторяющихся чисел
    //Console.WriteLine("[" + string.Join(", ", arrayRand) + "]");

    //int[] arrayRandShuffled = new int[arrayRand.Length];
    Shuffle(arrayRand);
    //Console.WriteLine("[" + string.Join(", ", arrayRand) + "]");

    int[,,] array3D = new int [m,n,k];
    int c = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int p = 0; p < array3D.GetLength(2); p++)
            {
                array3D[i,j,p] = arrayRand[c];
                c++;
            }
            
                        
        }
    }
     void PrintMatrix3D(int[,,] matrix3D)
    {
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3D.GetLength(1); j++)
            {
                for (int p = 0; p < matrix3D.GetLength(2); p++)
                {
                    Console.Write($"{matrix3D[i, j, p]}({i},{j},{p}) ");
                }
                Console.WriteLine();
            }
        }
    }
    PrintMatrix3D(array3D);
}



