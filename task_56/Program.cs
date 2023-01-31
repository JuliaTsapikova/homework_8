/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int[,] Get2DArray(int rowLength, int colLength, int start, int end)
{
    int[,] array = new int[rowLength, colLength];
    for(int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array [i,j] = new Random().Next(start, end + 1 );
        }
    }
    return array;

}

void Print2DArray(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    
}

void SumOfRows(int[,] array, int n)
{   int [] result = new int[n];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0;j < array.GetLength(1); j++)
        {   
            sum = sum + array[i,j];
        }
        result[i] = sum;
        sum = 0; 
    }
    int min = 0;
    for(int j = 1; j < array.GetLength(1); j++)
    {
        if(result[j] < result[min])
        {
            min = j;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min + 1}");
}

int[,] array = Get2DArray(4, 3, 0, 9);
Console.WriteLine("Исходный массив: ");
Print2DArray(array);
SumOfRows(array, 4);



