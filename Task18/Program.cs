//Задача 25: Напишите цикл, который 
//принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int cont = A;

while (cont == A)
{
    Console.Write(Math.Pow(A, B));
    break;
}

Console.WriteLine(" A в натуральную степень B" );