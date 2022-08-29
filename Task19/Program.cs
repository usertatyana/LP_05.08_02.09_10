//Задача 27: Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

    while (number > 0)
    {
        int num2 = number % 10;   // остаток от целочисленного деления
        number = number / 10;  // целочисленное деление
        sum = sum + num2;
    }


Console.WriteLine($"Сумма цифр: " + sum);
