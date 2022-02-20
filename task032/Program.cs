// Задача 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

/*
-   создать метод по вводу количества элементов с консоли, и перевести в интовый тип данных
-   создать метод по инициализации массива
-   вывести массив при помощи массива
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


int[] ArrayInit(int number)
{
    int[] newArray = new int[number];
    Random randomNum = new Random();
    for (int i = 0; i < number; i++)
    {
        newArray[i] = randomNum.Next(0, 2);
    }
    return newArray;
}

void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
}

int getInt = GetIntFromConsole($"Количество элементов массива: ");
int[] newArray = ArrayInit(getInt);
PrintArray(newArray);
