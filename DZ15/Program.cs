// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int nomer = Convert.ToInt32(Console.ReadLine());
if (nomer < 1 || nomer > 7)
{
Console.WriteLine("Нет такого дня недели");
}
else if (nomer < 5)
{
Console.WriteLine("Будни, надо поработать");
}
else
{
    Console.WriteLine("Выходной, можно и отдохнуть");
}