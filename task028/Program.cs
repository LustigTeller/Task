// Задача 28. Подсчитать сумму цифр в числе

/*
-   задать метод для генерации числа
-   при помощи цикла/метода сосчитать сумму (как сумма + остаток от деления заданного числа, которое в дальнейшем уменьшается на 1 разряд)
*/

int Random()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int number = Random();
Console.WriteLine($"Сгенерированное число: {number}");

int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}

Console.WriteLine($"Сумма цифр числа: {sum}");