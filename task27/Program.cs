// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int CountNumbers(int number)
{
    int result = 0;
    while (number > 0 )
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int number = Prompt("Введите число");
System.Console.WriteLine($"Сумма всех цифр в числе {number} = {CountNumbers(number)} ");
