//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;

if(number1 > number2 )
{
max = number1;
min = number2;
}
else
{
max = number2;
min = number1;
}
Console.WriteLine($"Максиамльное значение = {max}. Минимально значение = {min}");