// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int M = 1; 
int N = 15; 


int sum = SumNaturalNumbers(M, N); 
Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", M, N, sum);
    

int SumNaturalNumbers(int m, int n)
    {
        if (m == n) 
        {
            return m; 
        }
        else
        {
            return m + SumNaturalNumbers(m + 1, n); 
        }
    }