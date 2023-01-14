// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int a, int b)
{
    if(a==0) 
        return b+1;
    if(b==0) 
        return Akkerman(a-1,1);
    return Akkerman(a-1, Akkerman(a, b-1));
}

Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(M,N));