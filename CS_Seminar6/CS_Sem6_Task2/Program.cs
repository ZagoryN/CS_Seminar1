//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите через Enter угловой коэффициент k1 и пересечение с осью y b1 первой прямой: ");

int A = 2;
double[] coord1 = new double[A];

for (int i = 0; i < coord1.Length; i++)
{
    coord1[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Введите через Enter угловой коэффициент k2 и пересечение с осью y b2 второй прямой: ");
double[] coord2 = new double[A];

for (int i = 0; i < coord2.Length; i++)
{
    coord2[i] = double.Parse(Console.ReadLine());
}
//Console.WriteLine("Получившийся массив: [" + string.Join("; ", coord1) + "]");
//Console.WriteLine("Получившийся массив: [" + string.Join("; ", coord2) + "]");

Console.WriteLine($"Уравнение первой прямой: y = {coord1[0]}x + {coord1[1]}");
Console.WriteLine($"Уравнение второй прямой: y = {coord2[0]}x + {coord2[1]}");

if (coord1[0]==coord2[0] && coord1[1]!=coord2[1])
{
    Console.WriteLine("Прямые параллельны.");
}

else 
{
    if (coord1[0]==coord2[0] && coord1[1]==coord2[1])
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else 
    {
        double x = (coord2[1] - coord1[1]) / (coord1[0] - coord2[0]);
        double y = coord1[0] * (coord2[1] - coord1[1]) / (coord1[0] - coord2[0]) + coord1[1];

        Console.WriteLine($"Координаты точки пересечения прямых: [{x}; {y}]"); 
    }  
}


