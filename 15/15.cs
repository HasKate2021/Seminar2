// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число дня недели");
int day = int.Parse(Console.ReadLine());

if (day>7 || day<1 )
{
    Console.WriteLine("Число не подходит");
}
else if(day>0 && day<6)
{
    Console.WriteLine("Будний день");
}
else if (day>5 && day<8)
{
    Console.WriteLine("Выходной день");
}
