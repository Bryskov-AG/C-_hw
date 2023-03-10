// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int rowSmallestSum(int[,] array)
{
    int result = 1;
    int minSum = 0;
    int sum = 0;
    for (int m = 0;m < array.GetLength(1);m++)
    {
        minSum += array[0,m];
    }
    for (int i = 1;i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            sum+= array[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            result = i +1;
        }
        sum = 0;
    }
    return result;    

    
}



Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);                                     // row-- строка
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);                                     // col--столбец   

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

Console.WriteLine("== ==");

Console.WriteLine(rowSmallestSum(array2D));

