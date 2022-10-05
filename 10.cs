//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());

if (n<100 || n>1000)
{
    Console.WriteLine("Число не соответствует");
}
else 
{
    int b = ((n/10)%10);
    Console.WriteLine($"Вторая цифра числа: {b}");
}




