// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень возвести число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i =0; i<number2; i++)
{
    result = result * number;
}
Console.WriteLine(result);