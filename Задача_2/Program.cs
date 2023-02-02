// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число b: ");
int b = int.Parse(Console.ReadLine()!);

int max = a;
int min = b;

if (a>max) max = a;
if (b>max) max = b;
if (a<max) min = a;
if (b<max) min = b;


Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
