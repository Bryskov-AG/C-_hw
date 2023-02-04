// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 Console.Clear();

Console.WriteLine("Введите число от 1 до 7 : ");
int x = int.Parse(Console.ReadLine()!);

// int a = 1; // Понедельник
// int b = 2; // Вторник
// int c = 3; // Среда
// int d = 4; // Четверг
// int e = 5; // Пятница
// int f = 6; // Суббота
// int g = 7; // Воскресенье

// if (x==a) Console.WriteLine("Эх,будни.");
// if (x==b) Console.WriteLine("Эх,будни.");
// if (x==c) Console.WriteLine("Эх,будни.");
// if (x==d) Console.WriteLine("Эх,будни.");
// if (x==e) Console.WriteLine("Эх,будни.");
// if (x==f) Console.WriteLine("Выходной!");
// if (x==g) Console.WriteLine("Выходной!");

if (x > 5 && x < 8) 
{
    Console.WriteLine("Выходной!") ;
} 
else if (x > 0 && x < 6 )
{
    Console.WriteLine("Эх,будни.");
}
else if (x < 1 ||  x > 7)
{
    Console.WriteLine("Не правильно набран номер!");
}
