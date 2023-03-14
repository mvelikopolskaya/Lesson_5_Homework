// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArray(5, -10, 10);
PrintArray(array);
double maxmindiff = Math.Round(MaxMinDiff(array), 2);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {maxmindiff}");


double[] CreateArray(int size, double min, double max)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble(), 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxMinDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) max = arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i]) min = arr[i];
    }
    double diff = max - min;
    return diff;
}