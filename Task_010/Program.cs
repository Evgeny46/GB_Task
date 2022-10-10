/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */


int[] array = new int[5];
 //{2, 3, 4, 3, 2};
for(int i = 0; i<array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i} - ");
    array[i] = int.Parse(Console.ReadLine());
    //Random rand = new Random();
    //array [i] = rand.Next(2,5);
    
}

Console.WriteLine("Полученное число: ");

for(int i =0; i<array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не полиндром");
}
    
