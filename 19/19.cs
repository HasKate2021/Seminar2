// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
int Revers (int n1)
{
    int i = 0;
    while (n1 > 0)
    {
        i=i*10;
        i=i+n1%10;
        n1=n1/10;
     }
     return i;
 }

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);

if (n > 10000 && n < 99999)
{
    if (n==Revers(n))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }    
}    
else
{
     Console.WriteLine("Число не подходит");
}    
