// Задача: Транспонирование - 4

void RandomNumbers(int[,] array)
{   
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,11);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void RevertNumbers(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {  
           Console.Write($"{array[array.GetLength(0)-1-i,j]} \t"); 
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[N,M];
RandomNumbers(numbers);
Console.WriteLine();
RevertNumbers(numbers);

