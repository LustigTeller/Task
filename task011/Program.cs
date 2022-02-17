// Задача 22: Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите пространство (2D или 3D), в котором будут заданы координаты точек для поиска расстояния между ними");
string prostranstvo = Console.ReadLine();

double Prostrantvo2D(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distance;
}

double Prostrantvo3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

if (prostranstvo == "2D")
{
    Console.WriteLine("Введите координату x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y2: ");
    double y2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"Расстояние между заданными точками:  {Prostrantvo2D(x1, y1, x2, y2)}");
}
else if (prostranstvo == "3D")
{
    Console.WriteLine("Введите координату x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату z1: ");
    double z1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y2: ");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату z2: ");
    double z2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"Расстояние между заданными точками:  {Prostrantvo3D(x1, y1, x2, y2, z1, z2)}");
}

else
    Console.WriteLine("Введенно некорректное значение");








