﻿// Задача 31: 
//1.Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
//2.Найдите суммуотрицательных и положительных элементов массива.
//Вывод результата
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }
    return new int[]{sumNeg, sumPos};
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] sumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine($"Сумма отрицательных элементов = {sumPosNegElem[0]}");
Console.WriteLine($"Сумма положительных элементов = {sumPosNegElem[1]}");
