// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.WriteLine("Напишите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Напишите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int ostatok = FirstNumber % 10;

if (FirstNumber / SecondNumber == SecondNumber * SecondNumber)
{
    System.Console.WriteLine("Число: " + SecondNumber + " кратно числу " + FirstNumber);
}
else
{
    System.Console.WriteLine("Число: " + SecondNumber + " не кратно, остаток " + ostatok);
}