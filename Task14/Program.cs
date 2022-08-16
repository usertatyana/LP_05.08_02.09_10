//Задача 17.Напишите программу, которая принимает на вход координаты 
//точки (X, Y) причем
//X != 0 и Y != 0 и выдает номер четвертой плоскости, в которой 
//находится эта точка

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Первая четвердь");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четвердь");
else if (x < 0 && y < 0) Console.WriteLine("Третья четвердь");
else if (x > 0 && y < 0) Console.WriteLine("Четвертое число");
else Console.WriteLine("Введены не коректные данные");

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return"Первая четвердь";
    else if (xc < 0 && yc > 0) return"Вторая четвердь";
    else if (xc < 0 && yc < 0) return"Третья четвердь";
    else if (xc > 0 && yc < 0) return"Четвертое число";
    else return"Введены не коректные данные";    
}

string result = GetQuarter(x, y);
Console.WriteLine(result);

//int quarter = 0;
//if (x > 0 && y > 0) quarter = 1;
//else if (x < 0 && y > 0) quarter = 2;
//else if (x < 0 && y < 0) quarter = 3;
//else if ( x > 0 && y < 0) quarter = 4;

//if (x != 0 && y != 0) Console.WriteLine($"{quarter} четверть"); 
//else Console.WriteLine("Ввели не коректные координаты");
