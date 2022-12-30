// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void RandomNumbers(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void MultiplicationMatrix(int[,] array, int[,] array2)
{
   for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = array[i,j] * array2[i,j];
        }
    } 
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[N,M];
int[,] numbers2 = new int[N,M];
RandomNumbers(numbers);
PrintMatrix(numbers);
Console.WriteLine();
RandomNumbers(numbers2);
PrintMatrix(numbers2);
Console.WriteLine();
MultiplicationMatrix(numbers,numbers2);
PrintMatrix(numbers);

