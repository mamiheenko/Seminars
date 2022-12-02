// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int max =0;
for (int i =0; i<3; i++)
{
    Console.Write($"Введите {i+1} число: ");
    int number = int.Parse(Console.ReadLine());
    if (number>max)
    {
        max = number;
    }

}
Console.WriteLine($"Максимальное число: {max}");
