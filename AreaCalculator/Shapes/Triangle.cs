using AreaCalculator.Shapes.Interfaces;

namespace AreaCalculator.Shapes;

public class Triangle : IShape
{
    public Triangle(double side1, double side2, double side3)
    {
        if (double.IsNaN(side1)) throw new ArgumentException("Side shouldn't be NaN", nameof(side1));
        if (double.IsNaN(side2)) throw new ArgumentException("Side shouldn't be NaN", nameof(side2));
        if (double.IsNaN(side3)) throw new ArgumentException("Side shouldn't be NaN", nameof(side3));
        if (double.IsPositiveInfinity(side1) || double.IsNegativeInfinity(side1)) throw new ArgumentException("Side shouldn't be Infinity", nameof(side1));
        if (double.IsPositiveInfinity(side2) || double.IsNegativeInfinity(side2)) throw new ArgumentException("Side shouldn't be Infinity", nameof(side2));
        if (double.IsPositiveInfinity(side3) || double.IsNegativeInfinity(side3)) throw new ArgumentException("Side shouldn't be Infinity", nameof(side3));
        
        side1 = Math.Abs(side1);
        side2 = Math.Abs(side2);
        side3 = Math.Abs(side3);
        
        if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            throw new ArgumentException("Triangle condition not met");
            
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }

    public bool HasRightAngle()
    {
        return Math.Abs(Side1 - Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2))) < double.Epsilon || 
               Math.Abs(Side2 - Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2))) < double.Epsilon || 
               Math.Abs(Side3 - Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side1, 2))) < double.Epsilon;
    }
    
    public double CalculateArea()
    { 
        var semiPerimeter = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
    }
}