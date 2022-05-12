using AreaCalculator.Shapes.Interfaces;

namespace AreaCalculator;

public static class ShapeCalculator
{
    public static double Area(IShape shape)
    {
        return shape.CalculateArea();
    }
}