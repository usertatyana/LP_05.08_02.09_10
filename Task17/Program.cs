﻿//Напишите программу, которая 
//принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите чило: ");
int num = Convert.ToInt32(Console.ReadLine());
int cont = 1;

while (cont <= num )
{
    Console.Write($"{Math.Pow(cont, 3)}, ");
    cont++;
}
