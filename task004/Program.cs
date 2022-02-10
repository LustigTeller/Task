// Показать четные числа от 1 до N


// Через ввод с консоли

// Console.WriteLine("Введите целое число N");
// string numNStr = Console.ReadLine();
// int numN = int.Parse(numNStr);
// int pos = 1;
// Console.WriteLine("");
// while (pos <= numN)
// {
//     if (pos % 2 == 0) Console.Write($"{pos}; ");
//     pos++;
// }

// Через рандом

int numN=new Random().Next(1, 99);
Console.WriteLine(numN);
int pos = 1;
Console.WriteLine("");
while (pos <= numN)
{
    if (pos % 2 == 0) Console.Write($"{pos}; ");
    pos++;
}