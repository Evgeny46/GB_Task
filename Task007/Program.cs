/* Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

456 -> 46
782 -> 72
918 -> 98 */

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());


int result = (number / 100) * 10 + number % 10;


System.Console.WriteLine("Число без второй цифры: " + result);

//string ab = firstnumber.ToString();
//string dc = secondnumber.ToString();

//string FinalNumber = ab+dc; 
//Console.WriteLine("Итоговое число " + FinalNumber);


