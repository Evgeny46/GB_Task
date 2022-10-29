/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = new int[8];

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void FillArray(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = new Random().Next(100,1000);
    }
}

int NumbersEven(int[] arr3)
{
    int count = 0;
    for (int i = 0; i < arr3.Length; i++)
    {
        if(arr3[i] % 2 == 0) count++;
    }
    return count;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int result = NumbersEven(array);
Console.WriteLine("Количество четных чисел в массиве: " + result);