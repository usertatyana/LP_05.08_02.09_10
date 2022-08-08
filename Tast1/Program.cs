//Напишите программу, которая на вход принимает число и проверяет,
// является ли первое число квадратом
// a = 25, b =5-> да
// a = 2, b = 10-> нет
// a = 9, b = -3-> да
// a = -3, b = 9-> нет

Console.WriteLine("Введите первое чило: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine($"{a} является кватратом второго = {b}");
}
else
{
    Console.WriteLine($"{a} не является кватратом второго = {b}");  
}