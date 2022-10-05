// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

if (n<100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if(n>100 && n<1000)
{
    int a = (n%10);
    Console.WriteLine($"Третья цифра числа: {a}");
}
else if(n>1000)
{
    int m=n;
    while (m>1000)
    {
        m=m/10;
    }
    m=(m%10);
    Console.WriteLine($"Третья цифра числа: {m}");
}