// Задача 24: Найти кубы чисел от 1 до N

int InPunt(string message)
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

int [] IntArray (int number)
{
    int [] array = new int [number];
    for (int i = 0; i<number; i++)
    {
        array[i]= (i+1) * (i+1)* (i+1);
    }
    return array;
}

void PrintArray(int[]array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int number = InPunt("Введите число: ");
int [] array=IntArray(number);
PrintArray(array);



