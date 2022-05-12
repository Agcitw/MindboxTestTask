using AreaCalculator.Shapes.Interfaces;

namespace AreaCalculator.Shapes;

public class Circle : IShape
{
    public Circle(double radius)
    {
        if (double.IsNaN(radius)) throw new ArgumentException("Radius shouldn't be NaN", nameof(radius));
        if (double.IsPositiveInfinity(radius) || double.IsNegativeInfinity(radius)) throw new ArgumentException("Radius shouldn't be Infinity", nameof(radius));
        
        Radius = Math.Abs(radius);
    }

    public double Radius { get; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}