//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число : ");

string? number = Console.ReadLine(); // считываем строку
char[] array = number.ToCharArray();
char[] arrayNumber = number.ToCharArray();  //переводим строку в массив
Array.Reverse(arrayNumber); // разворачиваем массив
string arReverse = new string(arrayNumber);

if (arReverse.Length < 5 || arReverse.Length > 5) //проверяем на пятизначность
{
    Console.Write("Это не пятизначное число. Попробуйте ещё раз");
}
else {
    //Console.WriteLine(array);
    //Console.WriteLine(arReverse);
    bool a = Enumerable.SequenceEqual(array, arReverse);
    if (a == true)
    {
        Console.WriteLine("Это число - палиндром.");
    }
    else 
    {
        Console.WriteLine($"Число {number} не явлется палиндромом.");
    }
    
}
    


