// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void arithmeticMean(int[,] inArray)
{

}









Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);                                     // row-- строка
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);                                     // col--столбец   

int [,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
