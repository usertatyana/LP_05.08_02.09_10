﻿//  24.Напишите программу которая,
// принимает на вход число A и
// выдает сумму чисел
// 7-> 28
//4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= num; i++)
// {
    // sum = sum + i;
   // sum += i;
// }

//Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return  sum;
}

int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");