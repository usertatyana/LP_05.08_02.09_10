// Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3


Console.WriteLine("Введите первое чило: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.WriteLine($"Является max = {b}, Является min = {a}");
}
else 
{
    Console.WriteLine($"Является min = {b}, Является max = {a}");
}

