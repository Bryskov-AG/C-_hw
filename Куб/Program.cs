// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();

Console.Write("Введите число :");
int N = int.Parse(Console.ReadLine()!);

// if (N % 2 ==0)
// {
//     Console.WriteLine(N*N*N);
// }
// else Console.WriteLine("Число не чётное");


for ( int count = 2; count <= N; count += 2 )
{
     if (count % 2 == 0)
    Console.WriteLine(count * count * count );

}