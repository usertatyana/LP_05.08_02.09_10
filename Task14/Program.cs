//Напишите программу, которая принимает на вход координаты точки (X, Y) причем
//Xне равно 0 и Y не равно 0 и выдает номер четвертой плоскости, в которой 
//находится эта точка

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Первая четвердь");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четвердь");
else if (x < 0 && y < 0) Console.WriteLine("Третья четвердь");
else if ( x > 0 && y < 0) Console.WriteLine("Четвертое число");
else Console.WriteLine("Ввели не коректные координаты");
