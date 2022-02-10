// 10. Показать вторую цифру трёхзначного числа

//рандом
int number = new Random().Next(100, 999);
int firtNumber = 0;
int secondNumber = 0;
Console.WriteLine($"Случайное число: {number}");
firtNumber = number / 10;
secondNumber = firtNumber % 10;
Console.WriteLine($"Вторая цифра трехзначного числа:{secondNumber}");
// // либо в одним действием int n (новая переменная) = number / 10 % 10;

