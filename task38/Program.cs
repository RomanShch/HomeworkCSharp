// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}   ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double MinNumber(double[]arr)
{
    double min = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
    if(arr[i] < min)min = arr[i];
   }
   return min;
}

double MaxNumber(double[]arr)
{
    double max = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
    if(arr[i] > max)max = arr[i];
   }
   return max;
}

double DifferenceBetweenMinMax(double min1, double max1)
{
    double diff = max1 - min1;
    
    return diff;
}

double[] array = CreateArrayRndDouble(3, 1, 3);
PrintArray(array);
double min1= MinNumber(array);
double max1 = MaxNumber(array);
double differenceBetweenMinMax = DifferenceBetweenMinMax(min1, max1);
Console.Write($"    разница между максимальным и минимальным элементов массива = {differenceBetweenMinMax:F1}");