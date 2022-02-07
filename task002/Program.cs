// Найти максимальное из трех чисел


// Через рандом

// int numA = new Random().Next(1, 100);
// Console.WriteLine($"numA: {numA}");
// int numB = new Random().Next(1, 100);
// Console.WriteLine($"numA: {numB}");
// int numC = new Random().Next(1, 100);
// Console.WriteLine($"numA: {numC}");
// int max = numA;
// if (numB > max) max = numB;
// if (numC > max) max = numC;
// Console.WriteLine();
// Console.WriteLine($"max = {max}");


// Через ввод через консоль

Console.WriteLine("Введите целое число A");
string numAStr = Console.ReadLine();
int numA = int.Parse(numAStr);
Console.WriteLine("Введите целое число B");
string numBStr = Console.ReadLine();
int numB = int.Parse(numBStr);
Console.WriteLine("Введите целое число C");
string numCStr = Console.ReadLine();
int numC = int.Parse(numCStr);
int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;
Console.WriteLine();
Console.WriteLine($"max = {max}");