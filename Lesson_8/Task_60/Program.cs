// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void RandomNumbers(int[] array)
{
    for(int i=0;i<array.Length; i++)
    {
        var num = new Random().Next(10, 100);
        if (array.Contains(num)) i--; // уникальный элемент в массиве 
        else array[i] = num;     
    }              
}

void NumbersMatrix(int[,,] array, int[] array2) 
{   
    int l = 0;
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            for(int k = 0; k<array.GetLength(2); k++)
            {   
                array[i,j,k] = array2[l];
                l++;
            }
        }
    }
}

void PrintMatrix(int[,,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            for(int k = 0; k<array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите L: ");
int L = Convert.ToInt32(Console.ReadLine());
while((N*M*L)>90)
{   
    Console.Write("Ошибка! Массив должен быть меньше!\nВведите N: ");
    N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите M: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите L: ");
    L = Convert.ToInt32(Console.ReadLine());
}
int[,,] numbersMatrix = new int[N,M,L];
int[] numbers = new int[N*M*L];
RandomNumbers(numbers);
NumbersMatrix(numbersMatrix, numbers);
PrintMatrix(numbersMatrix);
