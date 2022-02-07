// Выяснить является ли число чётным


// Через ввод с консоли

Console.WriteLine("Введите целое число");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);
Console.WriteLine();
if (num % 2 == 0) Console.WriteLine($"Число {num} четное");
else Console.WriteLine($"Число {num} нечетное");


// Через рандом

// int numb = new Random().Next(1, 99);
// Console.WriteLine($"Случайное целое число {numb}");
// Console.WriteLine();
// if (numb % 2 == 0) Console.WriteLine($"Число {numb} четное");
// else Console.WriteLine($"Число {numb} нечетное");
