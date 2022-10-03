//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите последнее число диапазона: ");
int number = int.Parse(Console.ReadLine());
int count = 1;

while(count <= number)
{
    if(count % 2 == 0)
    {
        Console.WriteLine($"Число {count} является четным");
    }
    count++;
}

