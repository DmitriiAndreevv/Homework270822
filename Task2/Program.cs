/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.WriteLine("write A");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("write B");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("write A");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("write B");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("write A");
int i1 = int.Parse(Console.ReadLine());
Console.WriteLine("write B");
int i2 = int.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((i1 - i2), 2));

Console.WriteLine(ab); 