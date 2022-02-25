// Задача 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

/*
-   создать рандом для длины массива
-   создать метод по инициализации массива
-   создать метод, в котором считаться сумма чисел массива, стоящих на нечетной позиции
        - создать счетчик суммы
        - вычислить, как взять нечетную позицию массива
*/

int RandomNumber()
{
    Random randomizer = new Random();
    int number = randomizer.Next(5, 15);
    return number;
}

int[] InitArray(int num)
{
    Random randomizer = new Random();
    int[] newArr = new int[num];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = randomizer.Next(1, 11);
        Console.Write($"{newArr[i]}; ");
    }
    return newArr;
}

void Summ(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i > 0 && i % 2 > 0)
            summ = summ + arr[i];
    }
    Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечетной позиции = {summ}");
}

int number = RandomNumber();
Console.WriteLine($"Рандомное число: {number}");
Console.WriteLine();
int[] newArr = InitArray(number);
Console.WriteLine();
Summ(newArr);