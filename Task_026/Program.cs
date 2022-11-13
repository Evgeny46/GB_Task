/* Задача 3: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2

* по желанию */

Console.Clear();

int[,] matrix = new int[3,4];

void InitMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,30);
        }
        
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();        
    }
}

int sumMaxrows = 0;
int sumMincolumns = 0;

void MaxRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int max = matr[i, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] > max) max = matr[i,j];
        }
        Console.Write(max + " ");  
        sumMaxrows += max; 
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма максимальных значений в строках: " + sumMaxrows);
    
}

void MaxColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {   
        int max = matr[0, i];
        for (int j = 0; j < matr.GetLength(0); j++)
        {   
            if(matr[j, i] < max) max = matr[j,i];
        }    
         Console.Write(max + " ");
        sumMincolumns += max;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма минимальных значений в столбцах: " + sumMincolumns);
}

int Defference(int sumMaxrows, int sumMincolumns)
{
    int res = sumMaxrows - sumMincolumns;
    return res;
} 

InitMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
MaxRows(matrix);
System.Console.WriteLine();
MaxColumns(matrix);
System.Console.WriteLine();
int result = Defference(sumMaxrows, sumMincolumns);
System.Console.WriteLine("Разница между суммой максимальных значениях в строках и суммой минимальных значений в стодбцах: " + result);