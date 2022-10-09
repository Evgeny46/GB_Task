/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

645 -> 5
78 -> третьей цифры нет
326792 -> 6 */

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number < 100)
{
    System.Console.WriteLine("Ошибка! Третьей цифры нет.");
}

while(number > 999)
{
    number = number / 10;
}
int thirdnumber = number % 10;
System.Console.WriteLine("Третья цифра заданного числа: " + thirdnumber);


/* if(number > 99 & number < 1000)
{
    int thirdnumber = number % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if (number >= 1000 & number < 10000)
{
    int thirdnumber = (number / 10) % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if (number >= 10000 & number < 100000)
{
    int thirdnumber = (number / 100) % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if (number >= 100000 & number < 1000000)
{
    int thirdnumber = (number / 1000) % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if (number >= 1000000 & number < 10000000)
{
    int thirdnumber = (number / 10000) % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if (number >= 10000000 & number < 100000000)
{
    int thirdnumber = (number / 100000) % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if (number >= 100000000 & number < 1000000000)
{
    int thirdnumber = (number / 1000000) % 10;
    Console.WriteLine("Третье число: " + thirdnumber);
}
else if(number < 99)
{
    Console.WriteLine("Ошибка! Третьей цифры нет.");
} */