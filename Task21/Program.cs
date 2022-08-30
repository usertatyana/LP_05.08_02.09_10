// Задача 30. Напишите программу, которая
// выводит массив из 8 элементов,
// заполненый нулями и еденицами в случайном порядке
// [1, 0, 1, 1, 0, 1, 0, 0]

Console.WriteLine("Введите размер массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int[] res = RandArray(lenght);

void PrintArray(int[] res1)
{
    Console.Write($" " );
    for (int i = 0; i < res1.Length; i++)
    {
        Console.Write($"{res1[i]},");
    }
    Console.Write($" ");
}
PrintArray(res);
