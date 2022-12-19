// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PrintPositive(int[] array)
{   int count = 0;
    foreach(int element in array)
    {
        if (element>0) count++;
    } 
    return count;
}

Console.Clear();
Console.Write($"Введите количество элементов: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите элементы через запятую и пробел(', '): ");
int[] numbers = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
int result = PrintPositive(numbers);
Console.WriteLine($"Количество чисел больше нуля: {result} ");