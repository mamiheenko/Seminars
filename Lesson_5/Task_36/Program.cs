// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandomNumbers(int[] array)
{
    for(int i=0;i<array.Length; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
}

int SummResult(int[] array)
{   int result = 0;
    for(int i =0; i<array.Length;i++)
    {
        if (i%2!=0)
        {
            result+= array[i];
        }
    }
    return result;
}


Console.Clear();
Console.Write("Введите длину массива: ");
int user_length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[user_length];
RandomNumbers(numbers);
Console.WriteLine($"[{String.Join(", ", numbers)}]");
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {SummResult(numbers)}");

