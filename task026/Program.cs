// Задача 26. Возведите число А в натуральную степень B используя цикл
/*
1. Задать метод для ввода с консоли двух чисел
2. Считать два числа
3. Задать цикл для возведения в степень
*/

// int GetIntFromConsole(string message)    // метод на введение с консоли чисел
// {
//     Console.WriteLine(message);
//     string numberStr = Console.ReadLine();
//     int number = int.Parse(numberStr);
//     return number;
// }

int GetIntFromConsole(string message)
{
    int number = 0;
    bool IsError = true;
    while (IsError)
    {
        Console.WriteLine(message);
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out number)) IsError = number < 0;
    }
    return number;
}

int numberA = GetIntFromConsole("Введите число A: ");
int numberB = GetIntFromConsole("Введите число B: ");
int result = 1;
for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"{numberA} в степени {numberB} = {result}");