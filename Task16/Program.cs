//Задача 21.Напишите программу, которая принимает 
//на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//С помощью данной формулы можно рассчитать расстояние между двумя точками в пространстве:
//AB = √(xb — xa)2 + (yb — ya)2 + (zb — za)2
//xa; ya; za — координаты первой точки,
//xb; yb; zb — координаты второй точки.

Console.WriteLine("Введите x первой точеки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точеки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точеки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x1 вторая точека: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1 вторая точека: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1 вторая точека: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double cord = Math.Sqrt(Math.Pow((x2-x1), 2) +  Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

Console.WriteLine(Math.Round(cord, 2));

