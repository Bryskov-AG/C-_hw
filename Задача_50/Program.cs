// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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


void Xelement(int[,] inArray, int Xrow, int Xcol)
{
    if (inArray.GetLength(0) > Xrow && inArray.GetLength(1) > Xcol)
    Console.WriteLine(inArray[Xrow,Xcol]);
    else
    {
        Console.WriteLine("Такого элемента нет в данном массиве");
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);                                     // row-- строка
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);                                     // col--столбец   
int[,] array2D = GetArray(row, col, -10, 10);
Console.Write("Введите индекс элемента в строке,начиная с 0 : ");
int Xrow = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс элемента в столбце,начиная с 0 :");
int Xcol = int.Parse(Console.ReadLine()!);


PrintArray(array2D);
Xelement(array2D,Xrow,Xcol);

