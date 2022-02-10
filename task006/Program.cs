// 12. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 999);
int firtNumber = 0;
int secondNumber = 0;
Console.WriteLine($"Случайное число: {number}");
firtNumber = number / 100;
secondNumber = number % 10;
Console.WriteLine($"Удалили вторую цифру трехзначного числа:{firtNumber}{secondNumber}");