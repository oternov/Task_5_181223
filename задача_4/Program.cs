// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int[,] array = new int[3,3];
int[,] newarray = new int[array.GetLength(0)-1,array.GetLength(1)-1];

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

void MinElement()
{
    int rowmin = 0;
    int colmin = 0;
    int min = array[0,0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                rowmin = i;
                colmin = j;
            }
        }    
    }
    Console.WriteLine($"Минимальный элемент это {min} находится на строке {rowmin} и столбце {colmin}");
    
    int r = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != rowmin) 
        {
            int c = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != colmin) 
                {
                    newarray[r, c] = array[i, j];
                    c++;
                }
            }
            r++;
        }
    }
}

void PrintNewArray()
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            Console.Write(newarray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray();
Console.WriteLine();
MinElement();
PrintNewArray();