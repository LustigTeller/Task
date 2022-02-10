// 14. Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(1, 333);
int n = 0;
if (number <= 100)
{
    Console.WriteLine($"Это число: {number}");
    Console.WriteLine("Третьей цифры нет");
}
else
{
    n = number % 10;
    Console.WriteLine($"Число:{number}");
    Console.WriteLine($"Третья чифра числа:{n}");
}