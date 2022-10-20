/* Задача *: Напишите программу, которая из массива случайных чисел. 
Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
Постарайтесь сделать одним циклом
[1, 3, 5, 6, 6, 4] -> 5 */

Console.Clear();


int[] array = new int[8];
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write(array[i] + " ");
}
int min = array[0];
int max = array[0];
int secondMax = array[0];
for(int i = 0; i<array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
    else if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] > secondMax  && array[i] < max)
    {
        secondMax = array[i];
    }
}

System.Console.WriteLine();
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(secondMax);