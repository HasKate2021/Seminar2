// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine()!);

void Rev (int [] ar)
    {
        for (int i = 0; i < 5; i++)
        {
            ar[i] = ar[5 - 1 - i];
            Console.WriteLine($"{ar}");
            if (i<5)
            {
                Console.WriteLine(", ");
            }
        }
     }

if (n < 10000 || n > 99999)
{
     Console.WriteLine("Число не подходит");
}
else
{
    int m=Rev(n);
    if (n=m)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}    
