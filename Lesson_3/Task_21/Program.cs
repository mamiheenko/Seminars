// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write($"Введите x1 число: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите y1 число: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите z1 число: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите x2 число: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите y2 число: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите z2 число: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
Console.WriteLine(Math.Round(result, 2));

