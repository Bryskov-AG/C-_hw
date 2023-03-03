// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int M = 3;
int N = 2;

Console.WriteLine(AckermannFun(M, N));


int AckermannFun(int m, int n)
{
    if(m == 0) return n + 1;
    else if (n == 0) 
    return AckermannFun(m - 1, 1);
    else 
    return AckermannFun(m - 1, AckermannFun(m, n - 1));
}





