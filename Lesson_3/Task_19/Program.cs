// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите 5 значное число: ");
string number = Console.ReadLine();
if (number[0] == number[4])
{
    if (number[1] == number[3])
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}
else 
{
    Console.WriteLine("нет");
}

