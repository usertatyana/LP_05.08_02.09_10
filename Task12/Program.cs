//Напишите программу, которая 
//выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//Это решение я нашла но другое пыталась сама, но кажется, 
//что то не хватает.И пока до меня не доходит что именно.В цикле не получается                                                                                                                  
//Console.WriteLine("Введите число: "); 
//string number = Console.ReadLine();

//char[] numberArray = number.ToCharArray();      
//if (numberArray.Length >= 3)                 
//{
    //Console.WriteLine($"{number} -> {numberArray[2]}");
//}
//else
//{
    //Console.WriteLine($"{number} -> третьей цифры нет");
//}

Console.WriteLine($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int nov1 = 1000;

if (num > nov1)
{
    nov1 = num % 100;
    int nov2 = nov1 / 10;
    Console.WriteLine($"Третья цифра {nov2}");
}


if (num < 100)
{
    Console.WriteLine($"Нет третьей цифры");
}

if (num > 100 && num < 1000)
{
    int num1 = num % 10;
    Console.WriteLine($"Третья цифра {num1}");
}

