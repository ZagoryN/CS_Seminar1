//Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Задать размер (int) массива с клавиатуры
//[3 7 22 2 78] -> 76

double SearchMax (double[] arr) // метод поиска максимального элемента
{
    double Max = arr[0];
        
    for (int i=1; i < arr.Length; i++)
    {
        if (arr[i] > Max)
        {
            Max = arr[i];
        }
        else 
        {
            i++;
        }   
    }
    return Max;
}

double SearchMin (double[] arr) // метод поиска минимального элемента
{
    double Min = arr[0];
        
    for (int i=1; i < arr.Length; i++)
    {
        if (arr[i] < Min)
        {
            Min = arr[i];
        }
        else 
        {
            i++;
        }   
    }
    return Min;
}

Console.Write("Задайте размер массива: ");  // приглашение ко вводу
int A = Convert.ToInt32(Console.ReadLine()); // ввод числа A - size

if (A > 0)   //проверка на ввод
{
    double[] array = new double[A];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");  // приглашение ко вводу
    array[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Получившийся массив: [" + string.Join("; ", array) + "]");
double Max = SearchMax(array);
//Console.WriteLine(Max);
double Min = SearchMin(array);
//Console.WriteLine(Min);

double DiffMaxMin = Math.Abs(Max-Min);
Console.WriteLine($"Разница между максимальным и минимальным элементом - {DiffMaxMin}.");

}
else 
{
    Console.Write("У массива не может быть 0 или отрицательное кол-во элементов");
}

