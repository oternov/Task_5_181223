// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.WriteLine("Введите номер строки массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца массива");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[4,5];

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10,100);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ElementArray()
{
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в заданном масиве нет");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (row == i+1 && column == j+1)
                {
                    Console.WriteLine($"Элемент, находящийся на {row} строке и {column} столбце, равен {array[i,j]}.");
                }
            }
        }
    }
}


PrintArray();
ElementArray();