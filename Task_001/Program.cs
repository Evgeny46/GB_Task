// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
double FirstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double SecondNumber = double.Parse(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    Console.WriteLine("Наибольшее число: " + FirstNumber);
    Console.WriteLine("Наименьшее число: " + SecondNumber);
}

else if (FirstNumber == SecondNumber)
{
    Console.WriteLine("Числа равны");
}

else if (FirstNumber < SecondNumber)
{
    Console.WriteLine("Наибольшее число: " + SecondNumber);
    Console.WriteLine("Наименьшее число: " + FirstNumber);
}
