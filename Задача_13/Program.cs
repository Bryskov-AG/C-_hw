// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine()!);

if (a < 0)
{
    a = -a;
}
if (a < 100)
{
    Console.WriteLine("Число является двузначным,нет третьей цифры.");
} 
else if (a < 1000) {
    Console.WriteLine("Число является трёхзначным.");
    int c = (a  % 10);
    Console.WriteLine(c);
}
else
{
    int b = a;
    while (b > 999) 
    { 
          b = b / 10;
    }
    Console.WriteLine("Число является трёхзначным.");
    int c = (b  % 10);
    Console.WriteLine(c);
}
