Console.Clear();
Console.Write("Введите количество кустов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] result = new int[N];
while (N<3 || N>1000)
{
   Console.Write("Ошибка! Введите количество кустов от 3 до 1000: ");
    N= Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i<N; i++)
{
    Console.Write($"Ведите количество ягод с {i+1} куста: ");
    int count = Convert.ToInt32(Console.ReadLine());
    result[i]=count;
}
result = result.OrderByDescending(i=> i).ToArray();
Console.WriteLine(String.Join(", ", result));
Console.WriteLine(String.Join(", ", result[0] + result[1]+result[2]));

