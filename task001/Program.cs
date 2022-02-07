// C запозданием,к сожалению, но все же
// Даны два числа. Показать большее и меньшее число

// Через ввод с консоли

// Console.WriteLine("Введите целое число A ");
// string numberStrA = Console.ReadLine();
// int numberA = int.Parse(numberStrA);
// Console.WriteLine("Введите целое число B ");
// string numberStrB = Console.ReadLine();
// int numberB = int.Parse(numberStrB);
// if (numberA>numberB) Console.WriteLine($"Большее число: {numberA}, Меньшее число: {numberB}");
// else Console.WriteLine($"Большее число: {numberB}, Меньшее число: {numberA}");

// Через рандом

// int randomizer= new Random().Next(1,100); рандомайзер выдает одинаковые числа после ввода его в "int firstNum =.. и int secondNum =.." 
int firstNum = new Random().Next(1, 100);
Console.WriteLine($"{firstNum}");
int secondNum = new Random().Next(1, 100);
Console.WriteLine($"{secondNum}");
if (firstNum > secondNum) Console.WriteLine($"Большее число: {firstNum}, Меньшее число: {secondNum}");
else Console.WriteLine($"Большее число: {secondNum}, Меньшее число: {firstNum}");