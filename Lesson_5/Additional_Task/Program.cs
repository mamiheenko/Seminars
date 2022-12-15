void RandomNumbers(int[] array)
{
    for(int i=0;i<array.Length; i++)
    {
        // array[i] = new Random().Next(1,32);
        var num = new Random().Next(1,32);
        if (array.Contains(num)) i--; // уникальный элемент в массиве 
        else array[i] = num;     
    }              
}

void PrintOdd(int[] array)
{  
    Console.Write("Нечетные числа: ");
    for(int i =0; i<array.Length;i++)
    {
        if (array[i] % 2 !=0) 
        {   
            Console.Write($"{array[i]} ");
        }  
    }
}

void PrintEven(int[] array)
{   
    Console.WriteLine();
    Console.Write("Четные числа: ");
    for(int i =0; i<array.Length;i++)
    {
        if (array[i] % 2 ==0) 
        {   
            Console.Write($"{array[i]} ");
        }  
    }
}

string ResultWin(int[] array)
{   
    int CountOdd = 0;
    int CountEven = 0;
    for(int i =0; i<array.Length;i++)
    {
        if (array[i] % 2 ==0) CountEven++;
        else CountOdd++; 
    }
    if (CountEven > CountOdd) return "YES";
    else if (CountEven == CountOdd) return "Шансы равны!";
    else return "NO"; 
}


Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];
RandomNumbers(numbers);
Console.WriteLine($"[{String.Join(" ", numbers)}]");
PrintOdd(numbers);
PrintEven(numbers);
Console.WriteLine($"\n{ResultWin(numbers)}");








