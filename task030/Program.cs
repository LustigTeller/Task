// 30. Показать кубы чисел, заканчивающихся на четную цифру

/*
-   ввод с кансоли числа
-   считать его + проверка
-   определить, число с четной цифрой на конце
-   создать цикл для вычисления кубов данных чисел
*/

int GetIntFromConsole(string message)
{
    int number = 0;
    bool IsError = true;
    while (IsError)
    {
        Console.WriteLine(message);
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out number)) IsError = number <= 0;
    }
    return number;
}
int number = GetIntFromConsole("Введите число: ");
if (number % 2 == 0)
{
    for (int i = 2; i <= number; i = i + 2)
    {
        int value = i * i * i;
        Console.Write($"{value}; ");
    }
}
else
{
    number = number - 1;
    for (int i = 2; i <= number; i = i + 2)
    {
        int value = i * i * i;
        Console.Write($"{value}; ");
    }
}
