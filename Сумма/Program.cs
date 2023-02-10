// Подсчитать сумму цифр в числе

Console.Clear();

Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;
while (N != 0)
{
    sum += N % 10;
    N /= 10;
}
Console.WriteLine("Сумма цифр в числе : "+ sum);


