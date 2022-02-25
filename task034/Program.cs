// Задача 34. Написать программу замену элементов массива на противоположные.

/*
-   создать метод по вводу количества элементов с консоли, и перевести в интовый тип данных
-   создать метод по инициализации массива
-   создать метод, меняющий элементы на противоположные
*/

int InPut(string message)
{
    bool IsError = true;
    int number = 0;
    while (IsError)
    {
        Console.WriteLine(message);
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out number)) IsError = number <= 0;
    }
    return number;
}

int[] InitArray(int number)
{
    Random randomizer = new Random();
    int[] newArray = new int[number];

    for (int i = 0; i < number; i++)
    {
        newArray[i] = randomizer.Next(1, 10);
        Console.Write($"{newArray[i]}; ");
    }
    return newArray;
}

void SwitchArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"-{arr[i]}; ");
    }
}

int number = InPut("Введите число, задающее длину массива");
int[] newArray = InitArray(number);
Console.WriteLine();
SwitchArray(newArray);