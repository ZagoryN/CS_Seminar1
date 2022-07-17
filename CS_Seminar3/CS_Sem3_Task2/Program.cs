//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату первой точки x1: ");  
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату первой точки y1: ");  
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату первой точки z1: ");  
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки x2: ");  
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки y2: ");  
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату второй точки z2: ");  
int z2 = Convert.ToInt32(Console.ReadLine());   

int[] array1 = {x1,y1,z1};
int[] array2 = {x2,y2,z2};
// Math.Pow((x2-x1),2) - возведение в степень
double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));  //distance, расстояние
Console.Write(result);
