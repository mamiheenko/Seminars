// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)

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

string FindElementInMatrix(int[,] array, int N , int M)
{
  for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
           if(i==N-1 && j==M-1) return "есть такая позиция";
        } 
    }
    return "нет такой позиции";
}


Console.Clear();
int matrix1 = new Random().Next(1,6);   // задаю рандомную длину массива
int matrix2 = new Random().Next(1,6);
int[,] numbers = new int[matrix1,matrix2];
PrintRandomNumbers(numbers);
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElementInMatrix(numbers, N, M));

