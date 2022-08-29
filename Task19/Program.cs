//Задача 27: Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Summa = 0;
//for(i = 0; i < n; i++)
//Summa = Summa + A[i];

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма чисел {n} + {n} + {n} = {sum}");

