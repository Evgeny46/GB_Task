/* Задача 3: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();

int[] array = new int[8];

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,20);
        Console.Write($"{arr[i]} ");
    }
}

void MinMax(int[] arr)
{
    int max = array[0];
    int min = array[0];
for (int i = 0; i < arr.Length; i++)
{
    if(max < arr[i]) max = arr[i];
    else if(min > arr[i]) min = arr[i];   
}
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным значением и минимальным: " + (max - min));
}

PrintArray(array);
MinMax(array);



