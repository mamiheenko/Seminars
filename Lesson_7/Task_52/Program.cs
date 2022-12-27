// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintRandomNumbers(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void PrintAverageMatrix(int[,] array, int N)
{   
    for(int i =0; i<array.GetLength(1); i++)
    {   double average = 0;
        for(int j =0; j<array.GetLength(0); j++)
        {
            average += array[j,i];
        }
        average=Math.Round((average / N), 2);
        Console.Write($"{average}; ");
    } 
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[N,M];
PrintRandomNumbers(numbers);
PrintAverageMatrix(numbers, N);