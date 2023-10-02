// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string mes);
{
    System.Console.Write(mes);
    int value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Third(int N);
{
    while (N > 999)
    {
        N / 10;
    }
    return N % 10;
}

bool ValidateN(int N)
{
    if (N < 100)
    {
        System.Console.WriteLine("Третьей цифры нет.");
        return false;
    }
    return true;
}

int N = Prompt("Введите число: ");
if (ValidateN(N))
{
    System.Console.WriteLine(Third(N));
}
