// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] =Math.Round(new Random().NextDouble()*(maxValue - minValue)+ minValue,2);
    }
    return result;
}


double resultMax(double[]inArray)
{
    double max = inArray[0];
    for (int i = 0;i < inArray.Length;i++)
    {
        if (inArray[i] > max)
        max = inArray[i];
    }
    return max;
}

double resultMin(double[] inArray)
{
    double min = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] < min)
        min = inArray[i];
    }
    return min;
}

double[] array = GetArray(10,-10,10);
Console.WriteLine(String.Join(", ", array));
double max = resultMax(array);
double min = resultMin(array);
Console.WriteLine($"Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разница между Максимальным и Минимальным = {Math.Round(max-min,2)}");

