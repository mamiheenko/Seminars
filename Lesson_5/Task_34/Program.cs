// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void RandomNumbers(int[] array)
{
    for(int i=0;i<array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

int ResultCount(int[] array)
{   int count =0;
    for(int i = 0; i<array.Length;i++)
    {
        if (array[i] % 2 ==0) 
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите длину массива: ");
int user_length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[user_length];
RandomNumbers(numbers);
Console.WriteLine($"[{String.Join(", ", numbers)}]");
Console.WriteLine($"Количество четных чисел: {ResultCount(numbers)}");