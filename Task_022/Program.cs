/* Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();

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
        arr2[i] = new Random().Next(1,10);
    }
}

int NumbersUneven(int[] arr3)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < arr3.Length; i++)
    {
        if(i % 2 == 0) count++;
        else sum = sum + arr3[i]; 
    }
    return sum;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int result = NumbersUneven(array);
Console.WriteLine("Сумма нечетных элементов массива: " + result);
