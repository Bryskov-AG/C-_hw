// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine()!);
int result = 1;

for (int count = 1;count <= N;count++)
{
    result *=count;
}
Console.WriteLine(result);