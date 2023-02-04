// Напишите программу,которая принимает на вход трёхзначное число и на выходе показывает вторую цифру того числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число : ");

int a = int.Parse(Console.ReadLine()!);

int b = (a / 10) % 10;
Console.WriteLine(b);