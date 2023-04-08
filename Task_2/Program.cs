// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод координат точек
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("z1 = ");
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки:");
        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("z2 = ");
        double z2 = double.Parse(Console.ReadLine());

        // Вычисление расстояния между точками
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        // Вывод результата
        Console.WriteLine($"Расстояние между точками: {distance:F2}");
    }
}