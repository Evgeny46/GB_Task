/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();


    System.Console.WriteLine("Введите значение коэффициента х для первого уравнения: ");
    double k1 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите значение свободного члена для первого уравнения: ");
    double b1 = double.Parse(Console.ReadLine());


    System.Console.WriteLine("Введите значение коэффициента х для второго уравнения: ");
    double k2 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите значение свободного члена для второго уравнения: ");
    double b2 = double.Parse(Console.ReadLine());

    System.Console.WriteLine($"Первое уравнение: {k1}x + {b1}");
    System.Console.WriteLine($"Второе уравнение: {k2}x + {b2}");



void CalculationEquation(double k1, double k2, double b1, double b2)
{
    double res = k1 + k2 / (-1);
    double res2 = b2 + b1 / (-1);
    System.Console.WriteLine("Преобразуем уравнение для вычисления x: ");
    System.Console.WriteLine($"{res}x = {res2}");
    double x = res2 / res; 
    System.Console.WriteLine("Точка по координате X: " + x);
    double y = k1 * x + b1;
    System.Console.WriteLine("Точка по координате Y: " + y);
}

//PrintEquation();
CalculationEquation(k1, k2, b1, b2);