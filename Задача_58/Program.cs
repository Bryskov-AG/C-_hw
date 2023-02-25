// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
  

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

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);                                     // row-- строка
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);                                     // col--столбец   

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

// int[,] matrixProduct(int[,] FirstMatrix, int[,] secondMatrix)
// {
//     int[,] result = new int[FirstMatrix.GetLength(0), secondMatrix.GetLength(1)];

//     for (int i = 0; i < FirstMatrix.GetLength(0); i++);
//     {
//         for (int j = 0;j < secondMatrix.GetLength(1);j++);
//         {
//             int value = 0;

//             for (int k = 0;k < FirstMatrix.GetLength(1);k++);
//             {
//                 value += FirstMatrix[i,k] * secondMatrix[k,j];
//             }
//             result[i,j] = value;
//         }
//     }
//     return result;

// }