using System;

class Rectangle
{
    public double width;
    public double height;
    public static string figura;

    // Конструктор по умолчанию
    public Rectangle()
    {
        width = 1.0;
        height = 1.0;
    }

    // Конструктор с параметрами
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Конструктор копирования
    public Rectangle(Rectangle rectangle)
    {
        this.width = rectangle.width;
        this.height = rectangle.height;
    }

    // Статический конструктор
    static Rectangle()
    {
        figura = "Прямоугольник";
    }

    // Вычисление площади прямоугольника
    public double CalculateArea()
    {
        return width * height;
    }

    // Диструктор
    ~Rectangle()
    {
        Console.WriteLine("Диструктор вызван");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectDefault = new Rectangle();
        Console.WriteLine($"Ширина по умолчанию: {rectDefault.width}, Высота по умолчанию: {rectDefault.height}");
        Console.WriteLine($"Площадь по умолчанию: {rectDefault.CalculateArea()}");

        Rectangle rectCustom = new Rectangle(5.0, 3.0);
        Console.WriteLine($"Заданная ширина: {rectCustom.width}, Заданная высота: {rectCustom.height}");
        Console.WriteLine($"Площадь с заданными размерами: {rectCustom.CalculateArea()}");

        Rectangle rectCopy = new Rectangle(rectCustom);
        Console.WriteLine($"Скопированная ширина: {rectCopy.width}, Скопированная высота: {rectCopy.height}");
        Console.WriteLine($"Площадь скопированного прямоугольника: {rectCopy.CalculateArea()}");

        Console.WriteLine(Rectangle.figura);
    }
}
