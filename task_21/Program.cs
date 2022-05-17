// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("введите координату Х точки 1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("введите координаты Y точки 1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("введите координаты Z точки 1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("введите координаты X точки 2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("введите координаты Y точки 2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("введите координаты Z точки 2: ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine("координаты точки 1 (" + x1 + ";" + y1 + ";" + z1 + ")");
Console.WriteLine("координаты точки 2 (" + x2 + ";" + y2 + ";" + z2 + ")");

double res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine("расстояние равно = " + res);