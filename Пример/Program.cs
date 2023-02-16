//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма  положительных чисел равна 29, сумма отрицательных равна -20

int[] GetArray(int size, int minValue, int maxValue)     // []- обозначение массива   int size-количество элементов в массиве
{                                                        // minValue-минимальное значение в массиве    
    int[] result = new int[size];   // - массив,в кот будет храниться результат   // maxValue-максимальное значение в массиве

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);  // новое случайное число,в интервале от минимального до максимального
    }                                                           // (+1) -включительно
    return result;                                              // возвращаем массив result
}

Console.Clear();

int[] array = GetArray(12, -9, 9);   // создаём массив 12-элементов,с значением от -9 до 9
Console.WriteLine(String.Join(", ", array)); // распечатывает массив в 1 строку,через запятую из массива array
                                             // Join берёт коллекцию(у нас массив)и соединяет все элементы через разделитель(,_)   
int positiveSum = 0;  // счётчик подсчёта положительных чисел в массиве
int negativeSum = 0;  // счётчик подсчёта отрицательных чисел в массиве

foreach (int element in array)  // переменная,позволяющая брать всегда новый элемент?
{
    // if (element > 0)
    // {
    //     positiveSum += element;
    // }
    positiveSum += element > 0 ? element : 0;   // тернарный оператор
    negativeSum += element < 0 ? element : 0;
}

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         positiveSum += array[i];
//     } 
//     else 
//     {
//         negativeSum += array[i];
//     }
// }

Console.WriteLine($"Сумма положительных чисел равна: {positiveSum}, а отрицательных: {negativeSum}");
