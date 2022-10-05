/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
 */
Console.Clear();
Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine("Сформированное число: " + number);


if(number >= 10 & number <= 99)
{
    int firstnumber = number % 10;
    int secondnumber = number / 10;

    Console.WriteLine("Первое число: " + firstnumber);
    Console.WriteLine("Второе число: " + secondnumber);
    if(firstnumber > secondnumber)
    {
        Console.WriteLine("Наибольшее число: " + firstnumber);
    }
    else
    {
        Console.WriteLine("Наибольшее число: " + secondnumber);
    }
} 

