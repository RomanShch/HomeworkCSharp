 // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).


Console.WriteLine("Hello, World!");

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsPalindrome(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = number % 10000 / 1000;
    int fourthDigit = number % 100 / 10;
    int fifthDigit = number % 10;

    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}

int number = Prompt("Введите пятизначное число");
if (number < 10000 || number >= 100000)
{
    Console.WriteLine("Вы ввели не пятизначное число, пожалуйста повторите ввод");
    return;
}

bool isPalindrome = IsPalindrome(number);

Console.WriteLine(isPalindrome ? "Данное число является палиндромом." : "Данное число не является палиндромом.");
