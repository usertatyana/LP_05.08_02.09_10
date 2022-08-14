// Напишите программу, которая
//выводит случайное трех значное число, и
//удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int  RemoveSecond(int number);
{
   int number1 = number / 100;
   int number2 = number % 10;
   int nov = number1 * 10 + number2;
   return nov;
}

int result = RemoveSecond(number);
Console.WriteLine($"{number} -> {result}");