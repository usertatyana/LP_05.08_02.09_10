﻿// Напишите программу, которая
// принимает на вход число N
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

int result1 = Factorial(number);
Console.WriteLine($"Факториал ваше число {number} = {result1}");