
Console.Clear();
int[] arr = {1, 3, 4, 8, 9, 7, 2, 5, 6};

void PrintArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    
    for(int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[min]) min = j;
        }
        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
