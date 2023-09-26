// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
    Console.WriteLine("Введены некоректные данные");
    return;
}

int NaturalSumNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    else return num1 + NaturalSumNumbers(num1 + 1, num2);
}

if (number1 < number2)
Console.Write($"-> {NaturalSumNumbers(number1,number2)}");
if (number1 > number2)
Console.Write($"-> {NaturalSumNumbers(number2,number1)}");