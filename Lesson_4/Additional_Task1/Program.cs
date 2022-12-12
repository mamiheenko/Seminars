Console.Clear();
Console.Write("Введите количество цифр: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];
int[] new_numbers = new int[N];
for (int i=0; i<N; i++)
{
    Console.Write($"Введите {i+1} число: ");
    int user_number = Convert.ToInt32(Console.ReadLine());
    numbers[i] =user_number;
}
Console.WriteLine($"[{String.Join(", ", numbers)}]");
Console.Write("Введите цифру К: ");
int K = Convert.ToInt32(Console.ReadLine());

// {   int x = N-K;
//     for(int i=0; i<N; i++)
//     {   
//         new_numbers[i] = numbers[x];
//         x++;
//         if(x==N)
//         {   
//             for (int j =0; j<=K; j++)            // этот блок я сам сделал, но он не работает
//             {   
//                 i++;
//                 new_numbers[i] = numbers[j];
//                 
//             }
            
//         }
        
//     }
// }

if (K>0)
{  //*
    int z =0;                  
    for (int i=0; i<N; i++)
    {   
        z=i+K;   
        if (z>=N)
        {                            //этот блок мне помог сделать знакомый программист, остальное было написано мной)
             z-=N; 
        }
        new_numbers[z]= numbers[i];
    }
}  //*

else
{   int j =0;
    for (int i = K*(-1); i<N;i++ )
    {
        new_numbers[j] = numbers[i];
        j++;
    }
    int x = N-(-K);
    for (int i=0; i<K*(-1); i++)
    {
        new_numbers[x] = numbers[i];
        x++;
    }
}
Console.WriteLine($"Итог: [{String.Join(", ", new_numbers)}]");
