/* Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();

Console.WriteLine("Введите координаты первой точки А(x1, y1, z1): ");
double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine()), z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки B(x1, y1, z1): ");
double x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine()), z2 = double.Parse(Console.ReadLine());

double D = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1)));


double d = Math.Round(D, 2);


Console.WriteLine("Расстояние между точками: " + d);

//int SecondPoint = 