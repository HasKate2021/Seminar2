// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine()!);

int Rev (a, b, c, d, e )
    {
        for (int i = 0; i < 5; i++)
        {
            m = n(i) - 1 - i;
        }
    }

if (n < 10000 || n > 99999)
{
    Console.WriteLine("Нужно пятизначное число");
}
else
{
    int rev = Rev(n);
    Console.WriteLine(n);
}

