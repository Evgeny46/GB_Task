/* 
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). 
Использовать свои функции, не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void Clear()
{
Console.Clear();
}
Clear();

double Read(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double numberA = Read("Введите число A: ");
double numberB = Read("Введите число B: ");

//double result = Math.Pow(numberA, numberB);
double result = 1;
for(int i = 0; i < numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"{numberA} в степени {numberB} = " + result);



