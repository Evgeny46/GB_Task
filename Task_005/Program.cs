/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 & number < 1000)
{
    int secondnumber = (number / 10) % 10;
    Console.WriteLine("Второе число трехзначного числа: " + firstnumber);
}
else
{
    Console.WriteLine("Ошибка! Вы ввели не трехзначное число");
}