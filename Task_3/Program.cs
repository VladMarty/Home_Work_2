// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной день!");
}
else if (num <= 5)
{
    Console.WriteLine("Будний день!");
}
else if (num < 1 || num > 7)
{
    Console.WriteLine("В неделе 7 дней!");
}