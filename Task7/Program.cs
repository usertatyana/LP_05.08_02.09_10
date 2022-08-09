//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4->да
//-3->нет
//7->нет

Console.WriteLine("Введите чило: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num % 2;

if (count == 0)
{
    Console.Write($"{num} Четное ");
}
else
{

    Console.Write($"{num} Не четное ");
}    
