//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");

double number = double.Parse(Console.ReadLine());

if(number % 2 == 0)
Console.WriteLine("Число является четным");
else 
Console.WriteLine("Число нечетное");
