/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] Generate2DArrayFirst(int rowLength, int colLength, int start, int end)
{
    int[,] arrayFirst = new int[rowLength, colLength];
    for(int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            arrayFirst [i,j] = new Random().Next(start, end + 1 );
        }
    }
    return arrayFirst;

}

int[,] Generate2DArraySecond(int rowLength, int colLength, int start, int end)
{
    int[,] arraySecond = new int[rowLength, colLength];
    for(int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            arraySecond [i,j] = new Random().Next(start, end + 1 );
        }
    }
    return arraySecond;

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

int [,] MultiplicationOfMatrix(int[,] arrayFirst, int[,] arraySecond)
{   
    int[,] resulArray = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arraySecond.GetLength(0); k++)
            {
                resulArray[i,j] += arrayFirst[i,k] * arraySecond[k,j];
            }
        }
            
    }
    return resulArray;
}  


int n = GetUserData("Введите количество строк первой матрицы: ");
int m = GetUserData("Введите количество столбцов первой матрицы: ");
int[,] arrayFirst = Generate2DArrayFirst(n, m, 0, 9);
int k = GetUserData("Введите количество строк второй матрицы: ");
int l = GetUserData("Введите количество столбцов второй матрицы: ");
int[,] arraySecond = Generate2DArraySecond(k, l, 0, 9);
Console.WriteLine("Первая матрица: ");
Print2DArray(arrayFirst);
Console.WriteLine("Вторая матрица: ");
Print2DArray(arraySecond);
if(arrayFirst.GetLength(1) == arraySecond.GetLength(0))
{
    int[,] resulArray = MultiplicationOfMatrix(arrayFirst, arraySecond);
    Console.WriteLine("Итоговая матрица:");
    Print2DArray(resulArray);
}
    else
    {
        Console.WriteLine("Матрицы перемножать нельзя!");
    }

