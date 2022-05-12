using AreaCalculator;
using AreaCalculator.Shapes;
using AreaCalculator.Shapes.Interfaces;

namespace ClientPart;

public static class Program
{
    public static void Main()
    {
        IShape fig1 = new Circle(4);
        IShape fig2 = new Triangle(20, 20, 16);
        
        Console.WriteLine(ShapeCalculator.Area(fig1));
        Console.WriteLine(ShapeCalculator.Area(fig2));
    }
}