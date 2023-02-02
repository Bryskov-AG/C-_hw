// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите первое число a: ");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число b : ");

int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число с : ");

int c = int.Parse(Console.ReadLine()!);

int max = a;
int min = b;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);



