// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

int[,] array = new int[3,4];

void NewArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void RowArray()
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0)/2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i,j];
            array[i,j] = array[array.GetLength(0) - i - 1, j];
            array[array.GetLength(0) - i - 1, j] = temp;
        }
    }
}

NewArray();
PrintArray();
RowArray();
Console.WriteLine();
PrintArray();