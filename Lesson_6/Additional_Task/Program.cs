double ResultTask(double x1, double y1, double x2, double y2, double x3, double y3)
{
    double result = (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1);
    return Math.Abs(result/2);
}

Console.Clear();
Console.Write($"Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(ResultTask(x1, y1, x2, y2, x3, y3));

