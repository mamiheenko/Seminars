// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortedMatrix(int[,] array)
{  
    int temp = 0;
    for(int i =0; i<array.GetLength(0); i++)
    {   
        for(int j = 0; j<array.GetLength(1)-1; j++)
        {   
            for(int k = 0; k<array.GetLength(1)-1; k++)
            {     
                if(array[i,k]<array[i,k+1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                } 
            }
        }
    }
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[N,M];
RandomNumbers(numbers);
PrintMatrix(numbers);
SortedMatrix(numbers);
Console.WriteLine();
PrintMatrix(numbers);