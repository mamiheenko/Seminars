// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void RandomNumbers(double[] array)
{
    for(int i=0;i<array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(50-1)+1, 2);
    }
    
}

double ResultNumber(double[] array)
{   double max = array[0];
    double min = array[0];
    for(int i=0;i<array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max = {max}");
    double result = Math.Round(max - min, 2);
    return result;
}

Console.Clear();
Console.Write("Введите длину массива: ");
int user_length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[user_length];
RandomNumbers(numbers);
Console.WriteLine($"[{String.Join(", ", numbers)}]");
Console.WriteLine(ResultNumber(numbers));