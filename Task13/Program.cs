//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.WriteLine("Введите чило от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Понедельник работаем");
}
else if (a == 2)
{
    Console.WriteLine("Вторник работаем");
}
else if (a == 3)
{
    Console.WriteLine("Среда работаем");
}
else if (a == 4)
{
    Console.WriteLine("Четверг пака еще работаем");
}
else if (a == 5)
{
    Console.WriteLine("Пятница последний рабочий день");
}
else if (a == 6)
{
    Console.WriteLine("Ура выходной");
}
else if (a == 7)
{
    Console.WriteLine("Последний день выходного");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}

