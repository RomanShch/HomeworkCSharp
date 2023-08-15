//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number1 > number2 && number1 > number3)
{
max = number1;
}
else if(number2 > number1 && number2 > number3)
{
max = number2;
}
else if(number3 > number1 && number3 > number2)
{
max = number3;
}
else 
{
Console.WriteLine("Вы ввели одинаковые числа");
}

Console.WriteLine($"Максмальное из всех трех чисел - {max}");
