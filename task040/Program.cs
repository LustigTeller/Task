// Задача 40. В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.



//Через методы
int RandomNumber()
{
    Random randomizer = new Random();
    int number = randomizer.Next(5, 15);
    return number;
}

double[] InitArray(int num)
{
    Random randomizer = new Random();
    double[] newArr = new double[num];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = randomizer.NextDouble() * 100;
        Console.Write($"{newArr[i]}; ");
    }
    return newArr;
}

void Diff(double[] arr)
{
    double max = 0;
    double min = arr[0];
    double diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    diff = max - min;
    Console.WriteLine($"max = {max}; min = {min}");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом = {diff}");
}


int number = RandomNumber();
Console.WriteLine($"Рандомное число: {number}");
Console.WriteLine();
double[] newArr = InitArray(number);
Console.WriteLine();
Diff(newArr);


// int[] arr = { 4, 19, -5, 3, -45, 34, -1, 3 };
// int max = 0;
// int min = 0;
// int diff = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > max)
//         max = arr[i];                                                                                ЗАДАННЫЙ МАССИВ(чуть для другого)
//     else if (arr[i] < min)
//         min = arr[i];
// }
// diff=max-min;
// Console.WriteLine($"max = {max}; min = {min}");
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементом = {diff}");
