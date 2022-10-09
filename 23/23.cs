﻿// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

void Kub (int n)
{
    for (int i = 1; i<=n; i++)
    {
        Console.Write($"{i*i*i}");
        if (i != n)
        {
            Console.Write(", ");
        }
    }
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Kub(N);
