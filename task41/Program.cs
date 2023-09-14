// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Promt(string message)
{
    Console.WriteLine(message); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    return result;
}

int[] ArrayInput(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Promt($"Введите {i + 1} число ");
    }
    return arr;
}

int IfArrayPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i <arr.Length; i++)
    {
        if(arr[i] > 0) count ++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        
     Console.Write($"{arr[i]}");
    }
    
}

int cuatArr = Promt("укажите количество цифр которые хотите ввести  ");
int size = cuatArr;
Console.WriteLine();
int[] arrayInput = ArrayInput(size);
int ifArrayPositive = IfArrayPositive(arrayInput);
PrintArray(arrayInput);
Console.WriteLine();
Console.WriteLine($"в введенном Вами массиве  ---------- > {ifArrayPositive} положительных чисел.");

