using AreaCalculator.Shapes;
using System;
using Xunit;

namespace AreaCalculator.Test;

public class CircleTests
{
    [Fact]
    private void CreationOfCircleWithNaNRadius_ShouldThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(double.NaN));
    }
    
    [Fact]
    private void CreationOfCircleWithInfinityRadius_ShouldThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(double.PositiveInfinity));
        Assert.Throws<ArgumentException>(() => new Circle(double.NegativeInfinity));
    }
    
    [Fact]
    private void CreationOfCircleWithNegativeRadius_RadiusPropShouldBePositive()
    {
        Assert.Equal(1, new Circle(-1).Radius);
    }
    
    [Fact]
    private void CalculateArea_Test()
    {
        Assert.Equal(Math.PI, new Circle(1).CalculateArea());
        Assert.Equal(16 * Math.PI, new Circle(4).CalculateArea());
        Assert.Equal(Math.Pow(3.1, 2) * Math.PI, new Circle(3.1).CalculateArea());
    }
}