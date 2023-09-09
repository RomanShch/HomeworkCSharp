// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.



int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int RasingPower(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
       power *= powerBase; 
    }
    return power;

}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля.");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите число, которое хотите возвесит в степень");
int exponent = Prompt("Введите степень в которую хотите возвесит число");

if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} = {RasingPower(powerBase, exponent)}");
}
