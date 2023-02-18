// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


Console.Clear();

Console.WriteLine("Введите количество чисел : ");
int M = int.Parse(Console.ReadLine()!);

int countNumbers(int[]array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0)
        count++;
    }
    return count;
}


 int[]array = GetArray(M,-100,100);
 Console.WriteLine(String.Join(", ",array));
 int count = countNumbers(array);
 Console.WriteLine(count);