// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SummElementsString(int[,] array)
{   
    int[] summString = new int[array.GetLength(0)];
    for(int i =0; i<array.GetLength(0); i++)
    {   int result = 0;
        for(int j = 0; j<array.GetLength(1); j++)
        {
            result+=array[i,j];
            summString[i] = result;
        }
        Console.Write($"{summString[i]} ");
    }
    return summString;
}

void MinSummString(int[] array)
{   
    int min = array[0];
    int index = 0;
    for(int i =0; i<array.Length; i++)
    {   
        if(array[i]<min) 
        {
        min = array[i];
        index = i;
        }
    }
    Console.WriteLine($"\nНаименьшая сумма элементов: {min},  {index+1} строка");
}


Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
while (N==M)
{
    Console.Write("Ошибка! Введите прямоугольный массив. \nВведите N: ");
    N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите M: ");
    M = Convert.ToInt32(Console.ReadLine());
}
int[,] numbers = new int[N,M];
RandomNumbers(numbers);
PrintMatrix(numbers);
MinSummString(SummElementsString(numbers));