//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите трехзначное чило: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num / 10;
count = num % count;
Console.Write($"Последнее число {num} = {count}");
