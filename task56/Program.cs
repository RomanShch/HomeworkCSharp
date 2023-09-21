// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }

        Console.Write("|");
        Console.WriteLine();
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] AveregeSumNumbers(int[,] matrix, int columns)
{
    int[] sum = new int[columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i,j];
            
        }
        
    }
    return sum;
}

 int FindMinRowIndex(int[] arr)
 {

   int minNumber = arr[0];
   int minIndex = 0;
   for (int i = 1; i < arr.Length; i++)   
   {
    if(arr[i] < minNumber)
    {
        minNumber = arr[i];
        minIndex = i + 1;

    }
   }
   
   return minIndex;
 }

int[,] array = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array);
Console.WriteLine();
int[]averegeSumNumbers = AveregeSumNumbers(array, 4);
PrintArray(averegeSumNumbers);
Console.WriteLine();
 int findMinRowIndex = FindMinRowIndex(averegeSumNumbers);
  Console.WriteLine($"номер строки с наименьшей суммой элементов: {findMinRowIndex}");
