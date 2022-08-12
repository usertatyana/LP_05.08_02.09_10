//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа
// 78->8
//12->2
//13->8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

//int firstDigit = number / 10; // 7
//int secondDigit = number % 10; // 8

//if(firstDigit == secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> Цыфры одинаковые");
//else if (firstDigit == secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; //7
    int secondDigit = num % 10; //8
    if(firstDigit == secondDigit) return -1;
    return firstDigit >secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(88);
string res = result == -1 ? "Цифры одинаковые": result.ToString();
Console.WriteLine($"Наибольшая цифра числа {88} -> {res}");