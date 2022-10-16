/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Функция должна на вход принимать число, а выдавать сумму его цифр
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

/* int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
 */

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int NumberRes = int.Parse(number);
int result = 0;
int i = 0;
int sum = 0;
while(i < number.Length)
{
    result = NumberRes % 10;
    NumberRes = NumberRes / 10;
    sum += result; 
    i++;
}
Console.WriteLine("Сумма в введенном числе  " + sum); 

