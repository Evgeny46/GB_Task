
/* Задача 3: Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 7, 8 */

Console.Clear();


int[] array = new int[8];
void PrintArray()
{
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write($"{array[i]}, ");
}
}
PrintArray();