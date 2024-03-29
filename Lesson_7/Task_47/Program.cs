﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintRandomNumbers(double[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*(50+50)-50, 2);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[N,M];
PrintRandomNumbers(numbers);