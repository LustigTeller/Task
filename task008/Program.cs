// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int number = new Random().Next(1, 7);
if (number == 1)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Понедельник - будний день");
}
if (number == 2)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Вторник - будний день");
}
if (number == 3)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Среда - будний день");
}
if (number == 4)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Четверг - будний день");
}
if (number == 5)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Пятница - будний день");
}
if (number == 6)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Суббота - ВЫХОДНОЙ день!!!");
}
if (number == 7)
{
    Console.WriteLine($"Число: {number}");
    Console.WriteLine("Воскресенье - ВЫХОДНОЙ день!!!");
}
