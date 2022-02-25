// Задача 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

/*
-   создать метод по вводу количества элементов с консоли, и перевести в интовый тип данных
-   создать метод по инициализации массива
-   создать метод, в котором буду считаться количества нечетных\четных чисел
        - поставить счетчик четных/нечетных чисел
        - раскидать числа из массива и сочитать количество
*/


int InPut(string message)
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

int[] InitArray(int number)
{
    Random randomizer = new Random();
    int[] newArray = new int[number];
    for (int i = 0; i < number; i++)
    {
        newArray[i] = randomizer.Next(100, 999);
        Console.Write($"{newArray[i]}; ");
    }
    return newArray;
}

void PrintCol(int[] newArray)
{
    int colChet = 0;
    int colNeChet = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
            colChet++;
        else
            colNeChet++;
    }
    Console.WriteLine($"Количество четных чисел = {colChet}");
    Console.WriteLine($"Количество нечетных чисел = {colNeChet}");
}

int number = InPut("Введите число, задающее длину массива:");
int[] arr = InitArray(number);
Console.WriteLine();
PrintCol(arr);