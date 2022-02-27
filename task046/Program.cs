// Задача 46. Написать программу масштабирования фигуры

// В качестве фигуры беру треугольник 
// Коэфицент масштабирования k = 2

//Честно говоря, максимально не понял, как решить задачу. Воспользовался помощью.

using System.Linq;
string squareCoordinates = "(3,2) (5,5) (8,2)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(squareCoordinates);
var data = squareCoordinates.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: double.Parse(e[0]), y: double.Parse(e[1])))
                .Select(point => (point.x / 2, point.y / 2))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}