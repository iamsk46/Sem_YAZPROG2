// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Случайное число: {number}");
int First = number / 100;
int Third = number % 10;
int otvet = First * 10 + Third;
System.Console.WriteLine(otvet);