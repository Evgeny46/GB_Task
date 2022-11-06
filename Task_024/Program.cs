/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Разделить ввод данных, от расчета данных 
(Одна функция вводит данные, другая функция подсчитывает количество положительных)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


Console.Clear();

System.Console.WriteLine("Введите количество символов в массиве: ");
int elements = int.Parse(Console.ReadLine());
int[] array = new int[elements];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите элемент массива под индексом {i}: ");  
        arr[i] = int.Parse(Console.ReadLine()); 
    }
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");

    }
    
}

int Value(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count ++;
        
    }
    return count;
    
}

FillArray(array);
PrintArray(array);
int result = Value(array);
System.Console.WriteLine();
System.Console.WriteLine("Количество элементов больше 0 в массиве: " + result);