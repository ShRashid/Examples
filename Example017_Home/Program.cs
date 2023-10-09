// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите количество чисел для ввода: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for(int i = 0; i < M; i++)
// {
//     System.Console.WriteLine($"Ввидете {i+1}-е число: ");
//     if(Convert.ToInt32(Console.ReadLine()) > 0) count++;
// }

// System.Console.WriteLine("Количество положительных чисел = "+count);

//Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


    Console.WriteLine("Введите коэффициенты b1 и k1 для первой прямой:");
    double b1 = Convert.ToDouble(Console.ReadLine()),
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициенты b2 и k2 для второй прямой:");
    double b2 = Convert.ToDouble(Console.ReadLine()),
    k2 = Convert.ToDouble(Console.ReadLine());
    double x = 0;
    double y = 0;
       
    if (GetPoint())
    {
        Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются.");
    }

bool GetPoint()
{
   
    if (k1 == k2)
    {
         return false;
    }     
    else 
    {
        x = (b2 - b1) / (k1 - k2);
        y = k2 * x + b2;
        return true;
    }
}


