// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] GetArray(int m, int n, int minValue, int maxValue)                   // Функция,которая генерирует значения в двумерном массиве.
{                                                                           // м--строки  n--столбцы    мин и макс значения элементов в массиве
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)          // строки                          
    {
        for (int j = 0; j < n; j++)      // столбцы
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);        // Заполнение случайными целыми числами.
        }
    }
    return result;
}

void PrintArray(int[,] inArray)                                               // Функция,которая распечатывает двумерный массив,что бы увидить элементы массива.
{
    for (int i = 0; i < inArray.GetLength(0); i++)                            // строки
    {
        for (int j = 0; j < inArray.GetLength(1); j++)                        // столбцы
        {
            Console.Write($"{inArray[i, j]}\t ");                             // \t--для более табличного* отображения результатов
        }
        Console.WriteLine();
    }
}

void regularize(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            for (int k =1; k < array.GetLength(1);k++)
            if (array[i,k] > array[i,k-1])
            {
                temp = array[i,k-1];
                array[i,k-1] = array[i,k];
                array[i,k]= temp;
            }
        }
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);                                     // row-- строка
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);                                     // col--столбец   

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

Console.WriteLine("=   =   =   =   =   =   =   =   =  =");

regularize(array2D);
PrintArray(array2D);
