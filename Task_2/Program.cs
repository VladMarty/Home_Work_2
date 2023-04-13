// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num <= 999)
{
    num = num % 10;
    Console.WriteLine($"Третья цифра числа : {num}");
    
}   

else
{
    Console.WriteLine($"Третьей цифры нет ");
}


//Console.WriteLine($"Третьей цифры нет ");
//Console.WriteLine($"Третья цифра числа : {num}");