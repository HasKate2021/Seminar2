// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Координаты первой точки. Введите xa: ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите ya: ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите za: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Координаты второй точки. Введите xb: ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите yb: ");
int by = int.Parse(Console.ReadLine()!);
Console.Write("Введите zb: ");
int bz = int.Parse(Console.ReadLine()!);

double Rast (int x1, int y1, int z1,int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    return result;
}

Console.Write($"Длина отрезка AB равна: {Rast(ax,ay,az,bx,by,bz):f2}");
