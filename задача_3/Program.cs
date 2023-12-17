// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.


int[,] array = new int[5,3];
int[] arr = new int[array.GetLength(0)];

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void RowMin()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        int summin = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summin += array[i,j];      
        }
        arr[i] = summin;
    }
    
}

int MinPosition()
{
    int imin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i]<arr[imin])
        {
            imin = i;
        }
    }
    return imin;
}

PrintArray();
RowMin();
Console.WriteLine("Индекс строки с наименьшей суммой элементов - " + MinPosition());