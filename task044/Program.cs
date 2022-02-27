// Задача 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

/*
    -   при помощи рандома задаю значения b1, k1, b2 и k2
    -   провожу по формуле для поиска точки пересечения(либо ее отсутствия)
*/

Random randomiser = new Random();
double k1 = randomiser.Next(1, 10);
double b1 = randomiser.Next(1, 10);
double k2 = randomiser.Next(1, 10);
double b2 = randomiser.Next(1, 10);
Console.WriteLine($"Рандомные значения k1={k1}; b1={b1}; k2={k2}; b2={b2};");
double y = 0;
double x = 0;
/*
y = k1 * x + b1;
y = k2 * x + b2;

y - y = k1 * x + b1 - (k2 * x + b2);
y = k2 * x + b2;

0= k1 * x + b1 - k2 * x - b2;
y = k2 * x + b2;

(k1 * x) - (k2 * x) =  b1 - b2;
y = k2 * x + b2;
*/

x = (b1 - b2) / (k1 - k2);
y = k2 * x + b2;

if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются");
else
    Console.WriteLine($"Точка пересечения прямых ({x};{y})");