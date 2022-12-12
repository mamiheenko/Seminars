//  Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
//  После записи элементов в массив, необходимо его вывести на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.Write("Введите количество элементов: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[elements];
for (int i=0; i<elements; i++)
{
    Console.Write($"Введите {i+1} элемент: ");
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}
Console.WriteLine($"[{String.Join(", ", numbers)}]");