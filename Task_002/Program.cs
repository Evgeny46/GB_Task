//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
double FirstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double SecondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
double ThirdNumber = double.Parse(Console.ReadLine());

if (FirstNumber > SecondNumber & FirstNumber > ThirdNumber)
{
    Console.WriteLine("Наибольшее число: " + FirstNumber);
   
}

else if (SecondNumber > FirstNumber & SecondNumber > ThirdNumber)
{
    Console.WriteLine("Наибольшее число: " + SecondNumber);
   
}

else if (ThirdNumber > FirstNumber & ThirdNumber > SecondNumber )
{
    Console.WriteLine("Наибольшее число: " + ThirdNumber);
   
}

else if (ThirdNumber == FirstNumber & ThirdNumber == SecondNumber )
{
    Console.WriteLine("Ошибка! Числа равны");
   
}

